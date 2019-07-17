using DoctorVirtus.Aplicativo.Plugins;
using DoctorVirtus.Aplicativo.Views;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConexaoPage : ContentPage
    {
        public ConexaoPage()
        {
            InitializeComponent();
        }

        private async void BtnContinuar_Clicked(object sender, EventArgs e)
        {
            
            try
            {

                if (TxtCNPJ.Text.Trim() == "")
                {
                    await DisplayAlert("Atenção", "Informe o seu CNPJ/CPF", "Ok");
                    TxtCNPJ.Focus();
                    return;
                }

                Loading.Show();

                bool r = await Task.Run(() =>
                {
                    try
                    {
                        WebRequest oWebRequest = WebRequest.Create("http://www.atlantasistemas.com/clientes/" + TxtCNPJ.Text + "/config.xml");
                        WebResponse oWebResponse = oWebRequest.GetResponse();
                        StreamReader objSR = new StreamReader(oWebResponse.GetResponseStream());

                        File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "config.xml"), objSR.ReadToEnd());

                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                });

                Loading.Hide();

                if (r)
                    Application.Current.MainPage = new NavigationPage(new ViewLogin());
                else
                    await DisplayAlert("Atenção", "Não foi possível conectar \n\nVerifique sua conexão!", "Ok");

            }
            catch (Exception ex)
            {
                Loading.Hide();
                await DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }
    }
}