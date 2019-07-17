using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using DoctorVirtus.Aplicativo.Models;

namespace DoctorVirtus.Aplicativo.Sincronizacao {
    public static class SyncronizacaoNegociacao {

        public static bool isRunning = false;

        public static async Task<bool?> Atualizar(bool bShowLoading = false) {

            if (isRunning) return null;

            return await Task.Run(() => {
                try {

                    isRunning = true;

                    List<Negociacao> Negociacao = new List<Negociacao>();

                    if (App.PrestadorLogado == null) return false;

                    using (_ContextoBD Contexto = new _ContextoBD()) {
                        Negociacao = Contexto.Negociacao.Where(c => c.PrestadorID == App.PrestadorLogado.PrestadorID).ToList();
                    }

                    using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                        Contexto.Negociacao.RemoveRange(Contexto.Negociacao);

                        foreach(Negociacao row in Negociacao) {
                            Contexto.Negociacao.Add(row);
                        }
                        
                        Contexto.SaveChanges();
                    }
                    
                    return true;
                } catch (Exception ex) {
                    Console.Write(ex.Message);
                    return false;
                } finally {
                    isRunning = false;
                }
            });
        }
    }
}