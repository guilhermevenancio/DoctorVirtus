using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System;
using System.Linq;

using Plugin.Media;
using Plugin.Media.Abstractions;
using Acr.UserDialogs;
using System.Collections.ObjectModel;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

using System.Text;
using System.Data;
using System.IO;

using DoctorVirtus.Aplicativo.Models;
using DoctorVirtus.Aplicativo.Sincronizacao;
using DoctorVirtus.Aplicativo.Plugins;
using DoctorVirtus.Aplicativo.Utils;

namespace DoctorVirtus.Aplicativo.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ViewAgenda : TabbedPage {

        public Agenda ViewModelAgenda = new Agenda();
        
        public ObservableCollection<Imagem> ListImages = new ObservableCollection<Imagem>();
        public ObservableCollection<AgendaProcedimento> ListAgendaProcedimento = new ObservableCollection<AgendaProcedimento>();


        private List<Negociacao> Negociacao = new List<Negociacao>();


        //private object ctrlLocalAtendimento;
        //private object ctrlOperadora;

        public ViewAgenda() => InitializeComponent();
        
        protected async override void OnAppearing() {
            try {

                base.OnAppearing();
                
                await Task.Run(async () => {

                    //verifica se está atualizando, se estiver, aguarda a atualizãção finalizar para carregar os dados
                    while (SyncronizacaoNegociacao.isRunning) await Task.Delay(1000);

                    CarregarDados();

                });

                Loading.Hide();

            } catch (Exception ex) {
                await DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }

        private void CarregarDados() {
            //Busca as negociações do médico para preencher os locais de atendimento
            using (_ContextoSQLite Contexto = new _ContextoSQLite())
            {
                Negociacao = Contexto.Negociacao.Include("LocalAtendimento").Include("Operadora").Include("Tabela").Where(c => c.Ativo == true).ToList();

                List<LocalAtendimento> LocalAtendimento = new List<LocalAtendimento>();

                foreach (Negociacao row in Negociacao) {
                    if (LocalAtendimento.FirstOrDefault(c => c.LocalAtendimentoID == row.LocalAtendimentoID) == null) {
                        LocalAtendimento.Add(row.LocalAtendimento);
                    }
                }

                //CboLocalAtendimento.ItemsSource = LocalAtendimento;
                Device.BeginInvokeOnMainThread(() => CboLocalAtendimento.DataSource = LocalAtendimento.ToList());

            }
        }

        private async void Salvar() {
            try
            {
                
                var LocalAtendimento = (LocalAtendimento)CboLocalAtendimento.SelectedItem;
                var Operadora = (Operadora)CboOperadora.SelectedItem;

                if (TxtNumeroCartao.Text.Trim() == "")
                {
                    await DisplayAlert("Atenção", "Infome o número do cartão do paciente!", "Ok");
                    return;
                }

                if (TxtSenha.Text.Trim() == "")
                {
                    await DisplayAlert("Atenção", "Infome a senha de liberação!", "Ok");
                    return;
                }

                if (TxtPacienteNome.Text.Trim() == "")
                {
                    await DisplayAlert("Atenção", "Infome o nome do paciente!", "Ok");
                    return;
                }

                if (LocalAtendimento == null)
                {
                    await DisplayAlert("Atenção", "Infome o local de atendimento!", "Ok");
                    return;
                }

                if (Operadora == null)
                {
                    await DisplayAlert("Atenção", "Infome a operadora!", "Ok");
                    return;
                }

                if (ListAgendaProcedimento.Count == 0)
                {
                    await DisplayAlert("Atenção", "Nenhum procedimento informado!", "Ok");
                    return;
                }

                if (ListImages.Count == 0)
                {
                    await DisplayAlert("Atenção", "Nenhuma imagem informada!", "Ok");
                    return;
                }

                Loading.Show("Salvando");

                await Task.Run(() => {

                    using (_ContextoBD Contexto = new _ContextoBD())
                    {

                        ViewModelAgenda.AgendaProcedimento.Clear();
                        ViewModelAgenda.AgendaAnexo.Clear();


                        ViewModelAgenda.NumeroCartao = TxtNumeroCartao.Text;
                        ViewModelAgenda.SenhaLiberacao = TxtSenha.Text;
                        ViewModelAgenda.PrestadorID = App.PrestadorLogado.PrestadorID;
                        ViewModelAgenda.Paciente_Nome = TxtPacienteNome.Text;
                        ViewModelAgenda.LocalAtendimentoID = LocalAtendimento.LocalAtendimentoID;
                        ViewModelAgenda.OperadoraID = Operadora.OperadoraID;
                        ViewModelAgenda.DataInicial = DtpDataInicial.Date.Add(DtpHoraInicial.Time);
                        ViewModelAgenda.Finalizado = true;


                        Contexto.Agenda.Add(ViewModelAgenda);
                        Contexto.SaveChanges();

                        List<AgendaProcedimento> AgendaProcedimento = new List<AgendaProcedimento>();
                        List<AgendaAnexo> AgendaAnexo = new List<AgendaAnexo>();

                        foreach (AgendaProcedimento item in ListAgendaProcedimento)
                        {
                            AgendaProcedimento.Add(new AgendaProcedimento
                            {
                                AgendaID = ViewModelAgenda.AgendaID,
                                ProcedimentoID = item.ProcedimentoID,
                                Valor = item.Valor
                            });
                        }

                        foreach (Imagem img in ListImages)
                        {
                            AgendaAnexo.Add(new AgendaAnexo { AgendaID = ViewModelAgenda.AgendaID, Arquivo = File.ReadAllBytes(img.CaminhoImagem) });
                        }

                        Contexto.AgendaProcedimento.AddRange(AgendaProcedimento);
                        Contexto.AgendaAnexo.AddRange(AgendaAnexo);

                        Contexto.SaveChanges();

                    }

                });


                await DisplayAlert("Sucesso", "Salvo com sucesso!", "OK");

                await Navigation.PopAsync();

            } catch (Exception ex)
            {
                await DisplayAlert("Ops!", ex.Message, "Cancelar");
            }
            finally
            {
                Loading.Hide();
            }
            
        }

        private async void BtnAdicionarImagem_Clicked(object sender, EventArgs e) {
            try {

                var LocalAtendimento = CboLocalAtendimento.SelectedIndex;
                var Operadora = CboOperadora.SelectedIndex;

                UserDialogs.Instance.ActionSheet(new ActionSheetConfig()
                                .Add("Câmera", TirarFoto, "icons8_camera_42.png")
                                .Add("Galeria", EscolherFoto, "icons8_galeria_42.png")
                                .SetCancel("Cancelar"));

                CboLocalAtendimento.SelectedIndex = LocalAtendimento;
                CboOperadora.SelectedIndex = Operadora;

            } catch (Exception ex) {
                await DisplayAlert("Ops!", ex.Message, "Cancelar");
            }
        }

        private void BtnRemoverProcedimento_Clicked(object sender, EventArgs e)
        {

            var button = sender as Button;
            var procedimento = button.BindingContext as AgendaProcedimento;
            ListAgendaProcedimento.Remove(procedimento);

            ListViewProcedimento.ItemsSource = ListAgendaProcedimento;
        }

        private void BtnRemoverImagem_Clicked(object sender, EventArgs e) {

            var button = sender as Button;
            var imagem = button.BindingContext as Imagem;
            ListImages.Remove(imagem);
            
            ListView.ItemsSource = ListImages;
        }

        private async void TirarFoto() {

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.Current.IsCameraAvailable) {
                await DisplayAlert("Ops!", "Nenhuma câmera detectada.", "OK");
                return;
            }

            Loading.Show();

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions { SaveToAlbum = true, Directory = "Doctor Virtus" , ModalPresentationStyle = MediaPickerModalPresentationStyle.FullScreen});

            Loading.Hide();

            if (file == null) return;
            ListImages.Add(new Imagem { CaminhoImagem = file.Path });

            ListView.ItemsSource = ListImages;

            file.Dispose();
        }

        private async void EscolherFoto() {
            try
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("Ops", "Galeria de fotos não suportada.", "OK");
                    return;
                }

                Loading.Show();

                using (MediaFile file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions() { ModalPresentationStyle = MediaPickerModalPresentationStyle.FullScreen }))
                {
                    Loading.Hide();

                    if (file == null) return;
                    ListImages.Add(new Imagem { CaminhoImagem = file.Path });

                    ListView.ItemsSource = ListImages;
                }
                
            } catch (Exception ex)
            {
                await DisplayAlert("Atenção", ex.Message, "Ok");
            }

        }

        private void CboLocalAtendimento_SelectionChanged(object sender, Syncfusion.XForms.ComboBox.SelectionChangedEventArgs e)
        {
            try
            {
                var item = (LocalAtendimento)CboLocalAtendimento.SelectedItem;

                if (item == null)
                {
                    //CboLocalAtendimento.SelectedItem = ctrlLocalAtendimento;
                    //CboOperadora.SelectedItem = ctrlOperadora;
                    return;
                }

                using (_ContextoSQLite Contexto = new _ContextoSQLite())
                {

                    List<Operadora> Operadora = new List<Operadora>();

                    foreach (Negociacao row in Negociacao)
                    {
                        if (row.LocalAtendimentoID == item.LocalAtendimentoID)
                        {
                            Operadora.Add(row.Operadora);
                        }
                    }

                    CboOperadora.SelectedItem = null;
                    CboOperadora.DataSource = Operadora.ToList();

                    if (Operadora.Count == 1)
                    {
                        CboOperadora.SelectedIndex = 0;
                        Operadora_SelectionChanged(null, null);
                    }
                }

                //ctrlLocalAtendimento = CboLocalAtendimento.SelectedItem;

            } catch (Exception ex)
            {
                DisplayAlert("Atenção", ex.Message, "Ok");
            }
            
        }

        private void Operadora_SelectionChanged(object sender, Syncfusion.XForms.ComboBox.SelectionChangedEventArgs e)
        {
            try
            {
                var LocalAtendimento = (LocalAtendimento)CboLocalAtendimento.SelectedItem;
                var Operadora = (Operadora)CboOperadora.SelectedItem;

                if (Operadora == null) return;

                var item = Negociacao.FirstOrDefault(c => c.LocalAtendimentoID == LocalAtendimento.LocalAtendimentoID && c.OperadoraID == Operadora.OperadoraID);

                TxtTabela.Text = item.Tabela.Descricao;

                //ctrlOperadora = CboOperadora.SelectedItem;

            }
            catch (Exception ex)
            {
                DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }

        private async void TxtProcedimentoID_Unfocused(object sender, FocusEventArgs e) {
            try {

                await ProcurarProcedimento();

            } catch (Exception ex) {
                await DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }

        private async Task ProcurarProcedimento()
        {
            if (TxtCodigoTUSS.Text.Trim() == "")
            {
                TxtValorProcedimento.Text = "";
                return;
            }

            var LocalAtendimento = (LocalAtendimento)CboLocalAtendimento.SelectedItem;
            var Operadora = (Operadora)CboOperadora.SelectedItem;


            if (LocalAtendimento == null)
                return;
   
            if (Operadora == null)
                return;
         

            var Tabela = Negociacao.FirstOrDefault(c => c.LocalAtendimentoID == LocalAtendimento.LocalAtendimentoID && c.OperadoraID == Operadora.OperadoraID);

            StringBuilder query = new StringBuilder();

            query.AppendLine("SELECT");
            query.AppendLine("    Procedimento.ProcedimentoID");
            query.AppendLine("  , Procedimento.Descricao");
            query.AppendLine("  , ProcedimentoItem.QuantidadeCH_UCO");
            query.AppendLine("  , Negociacao.ValorCH_UCO");
            query.AppendLine("  , ProcedimentoItem.QuantidadeCH_UCO * Negociacao.ValorCH_UCO AS ValorProcedimento");
            query.AppendLine("FROM Procedimento");
            query.AppendLine("LEFT JOIN ProcedimentoItem ON Procedimento.ProcedimentoID = ProcedimentoItem.ProcedimentoID");
            query.AppendLine("INNER JOIN Negociacao ON Negociacao.PrestadorID = @PrestadorID AND Negociacao.LocalAtendimentoID = @LocalAtendimentoID AND Negociacao.OperadoraID = @OperadoraID");
            query.AppendLine("WHERE Procedimento.CodigoTUSS = @Referencia AND ProcedimentoItem.TabelaID = @TabelaID");

            DataSet ds = await Database.SQLite(query.ToString(), new object[,] {
                    {"@Referencia", TxtCodigoTUSS.Text},
                    {"@LocalAtendimentoID", LocalAtendimento.LocalAtendimentoID},
                    {"@OperadoraID", Operadora.OperadoraID},
                    {"@TabelaID", Tabela.TabelaID},
                    {"@PrestadorID", App.PrestadorLogado.PrestadorID}
                });

            TxtProcedimentoID.Text = ds.Tables[0].Rows[0]["ProcedimentoID"].ToString();
            TxtValorProcedimento.Text = string.Format("{0:0,0.00}", Math.Round(Convert.ToDecimal(ds.Tables[0].Rows[0]["ValorProcedimento"]), 2));
            TxtProcedimentoDescricao.Text = ds.Tables[0].Rows[0]["Descricao"].ToString();
            

        }

        private async void BtnAdicionarProcedimento_Clicked(object sender, EventArgs e) {
            try
            {

                await ProcurarProcedimento();


                var LocalAtendimento = (LocalAtendimento)CboLocalAtendimento.SelectedItem;
                var Operadora = (Operadora)CboOperadora.SelectedItem;

                if (LocalAtendimento == null)
                {
                    await DisplayAlert("Atenção", "Informe o local de atendimento!", "Ok");
                    return;
                }

                if (Operadora == null)
                {
                    await DisplayAlert("Atenção", "Informe a operadora!", "Ok");
                    return;
                }

                if (TxtCodigoTUSS.Text == "")
                {
                    await DisplayAlert("Atenção", "Informe o código TUSS do procedimento!", "Ok");
                    TxtCodigoTUSS.Focus();
                    return;
                }

                if (TxtValorProcedimento.Text == "")
                {
                    await DisplayAlert("Atenção", "Informe o valor do procedimento!", "Ok");
                    TxtValorProcedimento.Focus();
                    return;
                }

                var answer = await DisplayAlert("Deseja incluir?", TxtProcedimentoDescricao.Text, "SIM", "NÃO");
                if (!answer)
                {
                    return;
                }

                ListAgendaProcedimento.Add(new AgendaProcedimento() { AgendaID = null, ProcedimentoID = Convert.ToInt32(TxtProcedimentoID.Text), Procedimento = new Procedimento() { Descricao = TxtProcedimentoDescricao.Text }, Valor = Convert.ToDecimal(TxtValorProcedimento.Text) });
                ListViewProcedimento.ItemsSource = ListAgendaProcedimento;


                TxtProcedimentoID.Text = "";
                TxtCodigoTUSS.Text = "";
                TxtProcedimentoDescricao.Text = "";
                TxtValorProcedimento.Text = "";


            }
            catch (Exception ex)
            {
                await DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Salvar();
        }
        
    }

    public class Imagem {
        public string CaminhoImagem { get; set; }
    }

}