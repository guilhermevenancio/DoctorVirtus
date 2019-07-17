using DoctorVirtus.Aplicativo.Utils;
using System.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AtlantaMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProcedimentoPage : ContentPage
    {
        public ProcedimentoPage()
        {
            InitializeComponent();
        }

        private async void TxtTabelaID_Unfocused(object sender, FocusEventArgs e)
        {

            if (TxtTabelaID.Text == "")
            {
                TxtTabelaID.Text = "";
                TxtTabelaDescricao.Text = "";
                return;
            }

            string query = "SELECT ProdutoGrupoID, Descricao FROM ProdutoGrupo WHERE ProdutoGrupoID = @ProdutoGrupoID";

            DataSet ds = await Database.Execute(query, new object[,] {
                {"@ProdutoGrupoID", TxtTabelaID.Text, SqlDbType.Int}
            });

            if (ds.Tables[0].Rows.Count == 0)
            {
                await DisplayAlert("Atenção", "Tabela não encontrado!", "Ok");
                TxtTabelaID.Text = "";
                TxtTabelaDescricao.Text = "";
                //TxtParceiroID.Focus();
                return;
            }

            TxtTabelaID.Text = Parse.ToString(ds.Tables[0].Rows[0]["ProdutoGrupoID"]);
            TxtTabelaDescricao.Text = Parse.ToString(ds.Tables[0].Rows[0]["Descricao"]);


        }
    }
}