
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DoctorVirtus.Aplicativo.Plugins;
using Mono.Data.Sqlite;

namespace DoctorVirtus.Aplicativo.Utils
{
    class Database
    {
        
        public static string ConnectionString = "";

        public static async Task<DataSet> SQLite(string query, object[,] parametros = null, bool bShowLoading = false)
        {
            
            if (bShowLoading) Loading.Show();
            
            return await Task.Run(() =>
            {
                SqliteDataAdapter da = new SqliteDataAdapter();
                DataSet ds = new DataSet();
                
                using (SqliteConnection cn = new SqliteConnection("URI=file:" + App.dbPath)) {

                    using (SqliteCommand cmd = new SqliteCommand("", cn))
                    {

                        try
                        {
                            cmd.Connection.Open();

                            if (query != "")
                                cmd.CommandText = query;

                            if (parametros != null)
                            {
                                for (int i = 0; i <= parametros.GetUpperBound(0); i++)
                                    cmd.Parameters.AddWithValue(Convert.ToString(parametros[i, 0]), parametros[i, 1]);
                            }

                            da = new SqliteDataAdapter(cmd);
                            da.Fill(ds);

                            Loading.Hide();
                            return ds;

                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        finally
                        {
                            Loading.Hide();
                        }
                    }
                }
            }); 
        }

        public static async Task<DataSet> Execute(string query, object[,] parametros = null, bool bShowLoading = true)
        {

            if (bShowLoading) Loading.Show();


            return await Task.Run(() =>
            {
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();


                string sqlconection = "Data Source=saude.database.windows.net;Initial Catalog=Saude;User ID=user;Password=@Rped94ft;";//Min Pool Size=3;Max Pool Size=3;Connection Reset=True;Connection Lifetime=0;Connect Timeout=30;Current Language=Portuguese;";

                int iTentativa = 0;

            TentaNovamente:

                try
                {
                    iTentativa = iTentativa + 1;

                    using (SqlConnection cn = new SqlConnection(sqlconection))
                    {
                        using (SqlCommand cmd = new SqlCommand("", cn))
                        {
                            {
                                cmd.Connection.Open();
                                cmd.CommandText = "SELECT Versao FROM Empresa;";
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);

                    if (iTentativa < 5) goto TentaNovamente;

                    Loading.Hide();
                    throw new Exception("Falha na conexão!");
                }
                
                using (SqlConnection cn = new SqlConnection(sqlconection))
                {
                    using (SqlCommand cmd = new SqlCommand("", cn))
                    {
                        try
                        {
                            cmd.Connection.Open();

                            if (query != "")
                                cmd.CommandText = query;

                            if (parametros != null)
                            {
                                for (int i = 0; i <= parametros.GetUpperBound(0); i++)
                                    cmd.Parameters.AddWithValue(Convert.ToString(parametros[i, 0]), parametros[i, 1]).SqlDbType = (SqlDbType)parametros[i, 2];
                            }

                            da = new SqlDataAdapter(cmd);
                            da.Fill(ds);

                            Loading.Hide();
                            return ds;

                        } catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                        finally
                        {
                            Loading.Hide();
                        }
                    }
                }
            });
        }
        
    }
}