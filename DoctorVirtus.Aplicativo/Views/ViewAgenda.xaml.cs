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

        public ViewModelAgenda ViewModelAgenda = new ViewModelAgenda();
        public ObservableCollection<Imagem> ListImages = new ObservableCollection<Imagem>();
        public ObservableCollection<AgendaProcedimento> ListAgendaProcedimento = new ObservableCollection<AgendaProcedimento>();


        private List<Negociacao> Negociacao = new List<Negociacao>();

        public ViewAgenda() => InitializeComponent();
        
        protected async override void OnAppearing() {
            try {

                base.OnAppearing();
                
                await Task.Run(async () => {

                    //verifica se está atualizando, se estiver, aguarda a atualizãção finalizar para carregar os dados
                    while (SyncronizacaoNegociacao.isRunning) await Task.Delay(1000);

                    CarregarDados();

                });
                
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
                Device.BeginInvokeOnMainThread(() => CboLocalAtendimento.ItemsSource = LocalAtendimento.ToList());

            }
        }

        private void Salvar() {
            using (_ContextoSQLite Contexto = new _ContextoSQLite()) {

                var LocalAtendimento = (LocalAtendimento)CboLocalAtendimento.SelectedItem;
                var Operadora = (Operadora)CboOperadora.SelectedItem;
                
                ViewModelAgenda.Agenda.PrestadorID = App.PrestadorLogado.PrestadorID;
                ViewModelAgenda.Agenda.Paciente_Nome = TxtPacienteNome.Text;
                ViewModelAgenda.Agenda.LocalAtendimentoID = LocalAtendimento.LocalAtendimentoID;
                ViewModelAgenda.Agenda.OperadoraID = Operadora.OperadoraID;
                ViewModelAgenda.Agenda.DataInicial = DtpDataInicial.Date.Add(DtpHoraInicial.Time);
                ViewModelAgenda.Agenda.Finalizado = true;
                
                Contexto.Agenda.Add(ViewModelAgenda.Agenda);
                Contexto.SaveChanges();
                
                List<AgendaAnexo> AgendaAnexo = new List<AgendaAnexo>();
                
                /*foreach (AgendaProcedimento img in ListAgendaProcedimento) {
                    AgendaAnexo.Add(new AgendaAnexo { AgendaID = ViewModelAgenda.Agenda.AgendaID, Arquivo = File.ReadAllBytes(img.CaminhoImagem) });
                }*/

                foreach (Imagem img in ListImages) {
                    AgendaAnexo.Add(new AgendaAnexo { AgendaID = ViewModelAgenda.Agenda.AgendaID, Arquivo = File.ReadAllBytes(img.CaminhoImagem) });
                }
                
            }
        }

        private void BtnAdicionarImagem_Clicked(object sender, EventArgs e) {

            try {
                UserDialogs.Instance.ActionSheet(new ActionSheetConfig()
                                .Add("Câmera", TirarFoto, "icons8_camera_42.png")
                                .Add("Galeria", EscolherFoto, "icons8_galeria_42.png")
                                .SetCancel("Cancelar"));

            } catch (Exception ex) {
                DisplayAlert("Ops!", ex.Message, "Cancelar");
            }
            
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

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported) {
                await DisplayAlert("Ops", "Galeria de fotos não suportada.", "OK");
                return;
            }

            Loading.Show();

            var file = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions() { ModalPresentationStyle = MediaPickerModalPresentationStyle.OverFullScreen });

            Loading.Hide();

            if (file == null) return;
            ListImages.Add(new Imagem { CaminhoImagem = file.Path });

            ListView.ItemsSource = ListImages;

            file.Dispose();

        }

        private void CboLocalAtendimento_SelectedIndexChanged(object sender, EventArgs e) {

            var item = (LocalAtendimento)CboLocalAtendimento.SelectedItem;

            using (_ContextoSQLite Contexto = new _ContextoSQLite()) {

                List<Operadora> Operadora = new List<Operadora>();

                foreach (Negociacao row in Negociacao) {
                    if (row.LocalAtendimentoID == item.LocalAtendimentoID) {
                        Operadora.Add(row.Operadora);
                    }
                }

                CboOperadora.SelectedItem = null;
                CboOperadora.ItemsSource = Operadora.ToList();
                
                if (Operadora.Count == 1) {
                    CboOperadora.SelectedIndex = 0;
                    CboOperadora_SelectedIndexChanged(null, null);
                }
            }
        }

        private void CboOperadora_SelectedIndexChanged(object sender, EventArgs e) {

            var LocalAtendimento = (LocalAtendimento)CboLocalAtendimento.SelectedItem;
            var Operadora = (Operadora)CboOperadora.SelectedItem;

            if (Operadora == null) return;

            var item = Negociacao.FirstOrDefault(c => c.LocalAtendimentoID == LocalAtendimento.LocalAtendimentoID && c.OperadoraID == Operadora.OperadoraID);

            TxtTabela.Text = item.Tabela.Descricao;

        }

        private async void TxtProcedimentoID_Unfocused(object sender, FocusEventArgs e) {

            try {

                if (TxtProcedimentoID.Text.Trim() == "") {
                    TxtValorProcedimento.Text = "";
                    return;
                }

                var LocalAtendimento = (LocalAtendimento)CboLocalAtendimento.SelectedItem;
                var Operadora = (Operadora)CboOperadora.SelectedItem;
                var Tabela = Negociacao.FirstOrDefault(c => c.LocalAtendimentoID == LocalAtendimento.LocalAtendimentoID && c.OperadoraID == Operadora.OperadoraID);
                
                StringBuilder query = new StringBuilder();
                
                query.AppendLine("SELECT");
                query.AppendLine("    Procedimento.Descricao");
                query.AppendLine("  , ProcedimentoItem.QuantidadeCH_UCO");
                query.AppendLine("  , Negociacao.ValorCH_UCO");
                query.AppendLine("  , ProcedimentoItem.QuantidadeCH_UCO * Negociacao.ValorCH_UCO AS ValorProcedimento");
                query.AppendLine("FROM Procedimento");
                query.AppendLine("LEFT JOIN ProcedimentoItem ON Procedimento.ProcedimentoID = ProcedimentoItem.ProcedimentoID");
                query.AppendLine("INNER JOIN Negociacao ON Negociacao.PrestadorID = @PrestadorID AND Negociacao.LocalAtendimentoID = @LocalAtendimentoID AND Negociacao.OperadoraID = @OperadoraID");
                query.AppendLine("WHERE Procedimento.CodigoTUSS = @Referencia AND ProcedimentoItem.TabelaID = @TabelaID");
                
                DataSet ds = await Database.SQLite(query.ToString(), new object[,] {
                    {"@Referencia", TxtProcedimentoID.Text},
                    {"@LocalAtendimentoID", LocalAtendimento.LocalAtendimentoID},
                    {"@OperadoraID", Operadora.OperadoraID},
                    {"@TabelaID", Tabela.TabelaID},
                    {"@PrestadorID", App.PrestadorLogado.PrestadorID}
                });
                
                TxtValorProcedimento.Text = string.Format("{0:0,0.00}", Math.Round(Convert.ToDecimal(ds.Tables[0].Rows[0]["ValorProcedimento"]), 2));
                TxtProcedimentoDescricao.Text = ds.Tables[0].Rows[0]["Descricao"].ToString();
                
            } catch (Exception ex) {
                await DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }

        private void BtnAdicionarProcedimento_Clicked(object sender, EventArgs e) {

            TxtProcedimentoID.Text = "";
            TxtValorProcedimento.Text = "";
            TxtProcedimentoDescricao.Text = "";


            ListAgendaProcedimento.Add(new AgendaProcedimento() { AgendaID = null, ProcedimentoID = Convert.ToInt32(TxtProcedimentoID.Text), Procedimento = new Procedimento() { Descricao = TxtProcedimentoDescricao.Text}, Valor = Convert.ToDecimal(TxtValorProcedimento.Text) });
            ListViewProcedimento.ItemsSource = ListAgendaProcedimento;
        }



    }

    /*public class Procedimento {
        public string Descricao;
        public decimal? QuantidadeCH_UCO = 0;
        public decimal? ValorCH_UCO = 0;
        public decimal? ValorProcedimento = 0;
    }*/

    public class ViewModelAgenda {
        public Agenda Agenda = new Agenda();
    }

    public class Imagem {
        public string CaminhoImagem { get; set; }
    }

}