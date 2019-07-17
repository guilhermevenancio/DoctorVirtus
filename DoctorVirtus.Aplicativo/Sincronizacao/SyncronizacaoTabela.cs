using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using DoctorVirtus.Aplicativo.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorVirtus.Aplicativo.Sincronizacao {
    public static class SyncronizacaoTabela {

        public static bool isRunning = false;

        public static async Task<bool?> Atualizar(bool bShowLoading = false) {

            if (isRunning) return null;

            return await Task.Run(() => {
                try {

                    isRunning = true;

                    List<Tabela> Tabela = new List<Tabela>();

                    using (_ContextoBD Contexto = new _ContextoBD()) {
                        Tabela = Contexto.Tabela.ToList();
                    }

                    using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                        List<Tabela> Tabela_SQLite = Contexto.Tabela.AsNoTracking().ToList();

                        foreach (Tabela row in Tabela) {
                            if (Tabela_SQLite.FirstOrDefault(c => c.TabelaID == row.TabelaID) == null) {
                                Contexto.Tabela.Add(row);
                            } else {
                                Contexto.Tabela.Update(row);
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