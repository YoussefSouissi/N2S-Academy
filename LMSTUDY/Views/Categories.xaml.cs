using Microsoft.Maui.Controls;
using LMSTUDY.ViewModels;
using LMSTUDY.Models;

namespace LMSTUDY.Views
{
    public partial class Categories : ContentPage
    {
        public Categories()
        {
            InitializeComponent();
            var items = new List<CategoriesModel>
            {
                new CategoriesModel { Name = "Informatique"},
                new CategoriesModel { Name = "Réseau"},
                new CategoriesModel { Name = "Métier"},
                 
            };
            CategoriesList.ItemsSource = items;


        }
        private async void ViewCategorie(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Informatique());
        }

        private async void BackToHomePage(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new HomePage());
        }
    }
}
