using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using DoctorVirtus.Aplicativo.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorVirtus.Aplicativo.Sincronizacao {
    public static class SyncronizacaoPrestador {

        public static bool isRunning = false;

        public static async Task<bool?> Atualizar(bool bShowLoading = false) {

            if (isRunning) return null;

            return await Task.Run(() => {
                try {

                    isRunning = true;

                    if (App.PrestadorLogado == null) return false;

                    List<Prestador> Prestador = new List<Prestador>();
                    
                    using (_ContextoBD Contexto = new _ContextoBD()) {
                        Prestador = Contexto.Prestador.Where(c => c.PrestadorID == App.PrestadorLogado.PrestadorID).ToList();
                    }

                    using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                        List<Prestador> Prestador_SQLite = Contexto.Prestador.AsNoTracking().ToList();

                        foreach (Prestador row in Prestador) {
                            row.UsuarioID = null;
                            row.Usuario = null;

                            row.MunicipioID = null;
                            row.Municipio = null;
                            if (Prestador_SQLite.FirstOrDefault(c => c.PrestadorID == App.PrestadorLogado.PrestadorID) == null) {
                                Contexto.Prestador.Add(row);
                            } else {
                                Contexto.Prestador.Update(row);
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
