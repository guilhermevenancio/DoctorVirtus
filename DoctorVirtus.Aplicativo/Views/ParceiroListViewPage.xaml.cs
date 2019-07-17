using DoctorVirtus.Aplicativo.Interface;
using DoctorVirtus.Aplicativo.Plugins;
using DoctorVirtus.Aplicativo.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using Xamarin.Forms;

namespace AtlantaMobile
{
    public class Parceiro
    {
        public int? ParceiroID { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
    }

    public partial class ParceiroListViewPage : ContentPage
    {

        public List<Parceiro> Items = new List<Parceiro>();

        private Entry TxtParceiroID = new Entry();
        private Entry TxtNomeFantasia = new Entry();


        public ParceiroListViewPage(Entry TxtParceiroID, Entry TxtNomeFantasia)
        {
            InitializeComponent();

            this.TxtParceiroID = TxtParceiroID;
            this.TxtNomeFantasia = TxtNomeFantasia;
            
        }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                //your code here;

                CarregarGrid(false);
            }
            catch (Exception ex)
            {
                DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }

        private void TxtSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                CarregarGrid(false);

            }
            catch (Exception ex)
            {
                Display.Alert(this, "Atenção", ex.Message, "Ok");
            }
        }

        private async void CarregarGrid(bool bShowLoading = false)
        {

            string where = "WHERE 1=1 ";

            if (TxtSearchBar.Text != "")
                where += "AND NomeFantasia LIKE '%" + TxtSearchBar.Text + "%'";

            string query = "SELECT ParceiroID, CNPJ, NomeFantasia FROM Parceiro " + where;

            DataSet ds = await Database.SQLite(query, bShowLoading: bShowLoading);

            Items = new List<Parceiro>();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Items.Add(new Parceiro() { ParceiroID = Parse.ToInt(row["ParceiroID"]), NomeFantasia = Parse.ToString(row["NomeFantasia"]), CNPJ = Parse.ToString(row["CNPJ"]) });
            }

            Device.BeginInvokeOnMainThread(() => MyListView.ItemsSource = Items);

        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            if (e.Item == null) return;

            Parceiro item = (Parceiro)e.Item;

            TxtParceiroID.Text = Parse.ToString(item.ParceiroID);
            TxtNomeFantasia.Text = Parse.ToString(item.NomeFantasia);

            ((ListView)sender).SelectedItem = null;

            Navigation.PopAsync();

        }

        private void MyListView_Refreshing(object sender, EventArgs e)
        {
            try
            {

                //AtlantaSistemas.Sincronizacao.Parceiro.Sincronizar(true);

                MyListView.IsRefreshing = false;

                DependencyService.Get<IToast>().LongAlert("Atualizado com sucesso!");

            }
            catch
            {
                DependencyService.Get<IToast>().LongAlert("ERRO: Não foi possível atualizar!");
            }
        }

    } 
}
