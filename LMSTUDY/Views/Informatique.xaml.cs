namespace LMSTUDY.Views;
using LMSTUDY.Models;
using System;
using System.Security.Cryptography.X509Certificates;

public partial class Informatique : ContentPage
{
	public Informatique()
	{
		InitializeComponent();
       
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