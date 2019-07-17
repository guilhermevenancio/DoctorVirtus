using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;

using DoctorVirtus.Aplicativo.Models;
using DoctorVirtus.Aplicativo.Plugins;
using DoctorVirtus.Aplicativo.Sincronizacao;

namespace DoctorVirtus.Aplicativo.Views {

    public partial class ViewLogin : ContentPage {

        public ViewLogin() => InitializeComponent();
        
        private async void BtnEntrar_Clicked(object sender, EventArgs e) {
            try
            {
                if (TxtUsuario.Text.Trim() == "") {
                    await Display.Alert(this, "Atenção", "Informe o usuário!", "Ok");
                    TxtUsuario.Focus();
                    return;
                }

                if (TxtSenha.Text.Trim() == "") {
                    await Display.Alert(this, "Atenção", "Informe a senha!", "Ok");
                    TxtSenha.Focus();
                    return;
                }

                Loading.Show("Autênticando");

                App.UsuarioLogado = await Task.Run(() => {
                    using (_ContextoBD Contexto = new _ContextoBD()) {
                        return Contexto.Usuario.Include("Prestador").FirstOrDefault(c => c.Login == TxtUsuario.Text.ToUpper() && c.Senha == TxtSenha.Text.ToUpper());
                    }
                });

                if (App.UsuarioLogado == null) {
                    await Display.Alert(this, "Atenção", "Usuário ou senha errado!", "Ok");
                    TxtSenha.Text = "";
                    TxtSenha.Focus();
                    return;
                }

                List<string> Prestador = new List<string>();

                foreach (Prestador prestador in App.UsuarioLogado.Prestador)
                    Prestador.Add(prestador.NomeFantasia);

                if (Prestador.Count == 0) {
                    await Display.Alert(this, "Atenção", "Nenhum prestador cadastrado!", "Ok");
                    return;
                }

                if (Prestador.Count == 1) {
                    App.PrestadorLogado = App.UsuarioLogado.Prestador.FirstOrDefault();
                    await Atualizar();
                    Application.Current.MainPage = new MainPage();
                    return;
                }

                string action = await DisplayActionSheet("Selecione o prestador", "Cancelar", null, Prestador.ToArray());

                App.PrestadorLogado = App.UsuarioLogado.Prestador.FirstOrDefault(c => c.NomeFantasia == action);
                await Atualizar();
                Application.Current.MainPage = new MainPage();
                
            } catch (Exception ex) {
                await DisplayAlert("Atenção", ex.Message, "Ok");
            } finally {
                Loading.Hide();
            }
        }
        
        private async Task Atualizar() {
            using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                if (Contexto.Prestador.ToList().Count == 0) {
                    await SyncronizacaoPrestador.Atualizar();
                }
                if (Contexto.Operadora.ToList().Count == 0) {
                    await SyncronizacaoOperadora.Atualizar();
                }
                if (Contexto.Tabela.ToList().Count == 0) {
                    await SyncronizacaoTabela.Atualizar();
                }
                if (Contexto.LocalAtendimento.ToList().Count == 0) {
                    await SyncronizacaoLocalAtendimento.Atualizar();
                }
                if (Contexto.Negociacao.ToList().Count == 0) {
                    await SyncronizacaoNegociacao.Atualizar();
                }
                if (Contexto.Procedimento.ToList().Count == 0) {
                    await SyncronizacaoProcedimento.Atualizar();
                }
                if (Contexto.ProcedimentoItem.ToList().Count == 0) {
                    await SyncronizacaoProcedimentoItem.Atualizar();
                }
            }
        }

        private void BtnSair_Clicked(object sender, EventArgs e) {
            try {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            catch (Exception ex) {
                DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }
    }
}
