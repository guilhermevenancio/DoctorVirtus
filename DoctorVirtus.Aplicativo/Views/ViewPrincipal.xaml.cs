using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AtlantaMobile.Models;
using System.Collections.Generic;

namespace DoctorVirtus.Aplicativo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewPrincipal : ContentPage
    {
        //ItemsViewModel viewModel;

        public ViewPrincipal()
        {
            InitializeComponent();

            //BindingContext = viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var Items = new List<Item>
            {
                new Item { Id = 1, Text = "Minha agenda", Description = "Resumo de vendas" },
                new Item { Id = 2, Text = "Relatórios", Description = "Agenda, Procedimentos, Valor a receber, etc." },
                //new Item { Id = 3, Text = "Produtos", Description = "Cadastro e lista de produtos" },
            };

            ListView.ItemsSource = Items;

            //if (viewModel.Items.Count == 0) viewModel.LoadItemsCommand.Execute(null);
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            if (e.Item == null) return;

            Item item = (Item)e.Item;

            switch (item.Id) {
                case 1:
                    Navigation.PushAsync(new ViewAgenda());
                    //NavigationPage
                    break;
                case 2:
                    //case 2
                    break;
                default:
                    //case 3
                    break;
            }

            
            ListView.SelectedItem = null;

        }
        
    }
}