using DoctorVirtus.Aplicativo.Sincronizacao;
using System;
using System.Threading.Tasks;

namespace DoctorVirtus.Aplicativo.Services {

    public class AtualizacaoService {

        public static bool Atualizando = false;

        public async static Task<bool> Atualizar() {
            try {

                Atualizando = true;

                /*using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                    if (Contexto.Municipio.ToList().Count == 0) {
                        await SyncronizacaoMunicipio.Atualizar();
                    }
                }*/
                
                //await SyncronizacaoUsuario.Atualizar();
                await SyncronizacaoPrestador.Atualizar();
                await SyncronizacaoOperadora.Atualizar();
                await SyncronizacaoTabela.Atualizar();
                await SyncronizacaoLocalAtendimento.Atualizar();
                
                await SyncronizacaoNegociacao.Atualizar();

                await SyncronizacaoProcedimento.Atualizar();
                await SyncronizacaoProcedimentoItem.Atualizar();

                return true;

            } catch (Exception ex) {
                Console.Write(ex.Message);
                return false;
            } finally {
                Atualizando = false;
            }
        }
    }
}
