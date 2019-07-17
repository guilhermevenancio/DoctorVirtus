using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using DoctorVirtus.Aplicativo.Models;

namespace DoctorVirtus.Aplicativo.Sincronizacao {
    public static class SyncronizacaoMunicipio {

        public static bool isRunning = false;

        public static async Task<bool?> Atualizar(bool bShowLoading = false) {

            if (isRunning) return null;

            return await Task.Run(() => {
                try {

                    isRunning = true;

                    List<Municipio> Municipio = new List<Municipio>();

                    using (_ContextoBD Contexto = new _ContextoBD()) {
                        Municipio = Contexto.Municipio.ToList();
                    }

                    using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                        Contexto.Municipio.AddRange(Municipio);
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