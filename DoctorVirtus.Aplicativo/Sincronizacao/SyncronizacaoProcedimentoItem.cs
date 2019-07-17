using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using DoctorVirtus.Aplicativo.Models;

namespace DoctorVirtus.Aplicativo.Sincronizacao {
    public static class SyncronizacaoProcedimentoItem {

        public static bool isRunning = false;

        public static async Task<bool?> Atualizar(bool bShowLoading = false) {

            if (isRunning) return null;

            return await Task.Run(() => {
                try {

                    isRunning = true;

                    List<ProcedimentoItem> ProcedimentoItem = new List<ProcedimentoItem>();

                    using (_ContextoBD Contexto = new _ContextoBD()) {
                        ProcedimentoItem = Contexto.ProcedimentoItem.ToList();
                    }

                    using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                        Contexto.ProcedimentoItem.RemoveRange(Contexto.ProcedimentoItem);
                        Contexto.ProcedimentoItem.AddRange(ProcedimentoItem);

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
