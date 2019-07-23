
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DoctorVirtus.Aplicativo.Models;
using System.Threading.Tasks;
using System.IO;
using System;
using DoctorVirtus.Aplicativo.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace DoctorVirtus.Aplicativo {

    public partial class App : Application {

        public static string dbPath;
        public static Usuario UsuarioLogado;
        public static Prestador PrestadorLogado;

        public App(string dbPath) {
            InitializeComponent();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTI0MzA1QDMxMzcyZTMyMmUzMEZwZG1XNjBoaCtQcUFBS1duMmtJWThiYWx6cTRqNjQ3RjR4NG01MFFBcFU9");
            
            DatabaseInit(dbPath);

            //MainPage = new ViewAgenda();
            //MainPage = new MainPage();
            MainPage = new ViewLogin();

        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }

        private async void DatabaseInit(string dbPath) {

            App.dbPath = dbPath;

            await Task.Run(() => {
                if (!File.Exists(dbPath)) {
                    Console.Write("Database não existe!");
                    using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                        Contexto.Database.EnsureCreated();
                    }
                }
                /*using (_ContextoSQLite Contexto = new _ContextoSQLite()) {
                    Contexto.Database.Migrate();
                }*/
            });
        }
    }
}
