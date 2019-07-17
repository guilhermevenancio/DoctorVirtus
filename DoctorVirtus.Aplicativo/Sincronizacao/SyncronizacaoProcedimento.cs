using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using DoctorVirtus.Aplicativo.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorVirtus.Aplicativo.Sincronizacao {
    public static class SyncronizacaoProcedimento {

        public static bool isRunning = false;

        public static async Task<bool?> Atualizar(bool bShowLoading = false) {

            if (isRunning) return null;

            return await Task.Run(() => {
                try {

                    isRunning = true;

                    List<Procedimento> Procedimento = new List<Procedimento>();

                    using (_ContextoBD Contexto = new _ContextoBD()) {
                        Procedimento = Contexto.Procedimento.ToList();
                    }

                    using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                        List<Procedimento> Procedimento_SQLite = Contexto.Procedimento.AsNoTracking().ToList();

                        foreach (Procedimento row in Procedimento) {

                            if (Procedimento_SQLite.FirstOrDefault(c => c.ProcedimentoID == row.ProcedimentoID) == null) {
                                Contexto.Procedimento.Add(row);
                            } else {
                                Contexto.Procedimento.Update(row);
                            }
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
