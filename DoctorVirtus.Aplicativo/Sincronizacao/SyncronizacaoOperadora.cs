using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using DoctorVirtus.Aplicativo.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorVirtus.Aplicativo.Sincronizacao {
    public static class SyncronizacaoOperadora {

        public static bool isRunning = false;

        public static async Task<bool?> Atualizar(bool bShowLoading = false) {

            if (isRunning) return null;

            return await Task.Run(() => {
                try {

                    isRunning = true;

                    List<Operadora> Operadora = new List<Operadora>();

                    using (_ContextoBD Contexto = new _ContextoBD()) {
                        Operadora = Contexto.Operadora.ToList();
                    }

                    using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                        List<Operadora> Operadora_SQLite = Contexto.Operadora.AsNoTracking().ToList();

                        foreach (Operadora row in Operadora) {
                            if (Operadora_SQLite.FirstOrDefault(c => c.OperadoraID == row.OperadoraID) == null) {
                                Contexto.Operadora.Add(row);
                            } else {
                                Contexto.Operadora.Update(row);
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
