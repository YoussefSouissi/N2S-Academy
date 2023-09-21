namespace LMSTUDY.Views;
using LMSTUDY.Models;
using LMSTUDY.ViewModels;
using Microsoft.VisualBasic;
using System;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using FormationModel = LMSTUDY.Models.InformatiqueModel;
public partial class Informatique : ContentPage
{
    private InformatiqueViewModel viewModel;

    public Informatique(System.Guid id)
    {
        InitializeComponent();
        viewModel = new InformatiqueViewModel();
        BindingContext = viewModel;
        viewModel.SelectedCategoryId = id;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await viewModel.LoadFormationsByCategory();
    }





    private async void BackToCategoriesPage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new Categories());
    }

    private async void ToFormationPage(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new FormationPage());
    }

}