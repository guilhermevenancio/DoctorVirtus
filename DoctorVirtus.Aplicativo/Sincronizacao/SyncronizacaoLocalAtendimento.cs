using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using DoctorVirtus.Aplicativo.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorVirtus.Aplicativo.Sincronizacao {
    public static class SyncronizacaoLocalAtendimento {

        public static bool isRunning = false;

        public static async Task<bool?> Atualizar(bool bShowLoading = false) {

            if (isRunning) return null;

            return await Task.Run(async () => {
                try {

                    isRunning = true;

                    List<LocalAtendimento> LocalAtendimento = new List<LocalAtendimento>();

                    using (_ContextoBD Contexto = new _ContextoBD()) {
                        LocalAtendimento = Contexto.LocalAtendimento.ToList();
                    }

                    using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                        List<LocalAtendimento> LocalAtendimento_SQLite = Contexto.LocalAtendimento.AsNoTracking().ToList();

                        foreach (LocalAtendimento row in LocalAtendimento) {
                            row.MunicipioID = null;
                            row.Municipio = null;
                            if (LocalAtendimento_SQLite.FirstOrDefault(c => c.LocalAtendimentoID == row.LocalAtendimentoID) == null) {
                                Contexto.LocalAtendimento.Add(row);
                            } else {
                                Contexto.LocalAtendimento.Update(row);
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
