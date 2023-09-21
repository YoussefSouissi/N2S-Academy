using Microsoft.Maui.Controls;
using LMSTUDY.ViewModels;
using LMSTUDY.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

using categories = LMSTUDY.Models.CategoriesModel;

namespace LMSTUDY.Views
{
    public partial class Categories : ContentPage
    {
        private const string ApiUrl = "https://10.0.2.2:7107/api/Categorie";
        public Categories()
        {
            InitializeComponent();
            FetchCategories();
        }

        private async void FetchCategories()
        {
            try
            {
                var httpClient = new HttpClientService().GetPlatformSpecificHttpClient();
                var categorie = await httpClient.GetFromJsonAsync<List<categories>>(ApiUrl);
                CategoriesList.ItemsSource = categorie;            
            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", $"Error fetching categories: {ex.Message}", "OK");
            }
        }

        private async void ViewCategorie(object sender, EventArgs e)
        {
            if (CategoriesList.SelectedItem is categories selectedCategory)
            {
                await Navigation.PushAsync(new Informatique(selectedCategory.Id));
            }
        }



        private async void BackToHomePage(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new HomePage());
        }
    }

    

        
    
}
