using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using DoctorVirtus.Aplicativo.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorVirtus.Aplicativo.Sincronizacao {
    public static class SyncronizacaoUsuario {

        public static bool isRunning = false;

        public static async Task<bool?> Atualizar(bool bShowLoading = false) {

            if (isRunning) return null;

            return await Task.Run(() => {
                try {

                    isRunning = true;

                    if (App.UsuarioLogado == null) return false;

                    List<Usuario> Usuario = new List<Usuario>();
                    
                    using (_ContextoBD Contexto = new _ContextoBD()) {
                        Usuario = Contexto.Usuario.Where(c => c.UsuarioID == App.UsuarioLogado.UsuarioID).ToList();
                    }

                    using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                        List<Usuario> Usuario_SQLite = Contexto.Usuario.AsNoTracking().ToList();

                        foreach (Usuario row in Usuario) {
                            row.UsuarioGrupo = null;
                            
                            if (Usuario_SQLite.FirstOrDefault(c => c.UsuarioID == App.UsuarioLogado.UsuarioID) == null) {
                                Contexto.Usuario.Add(row);
                            } else {
                                Contexto.Usuario.Update(row);
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