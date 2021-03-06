﻿using System;
using TestXamarinApp.Constants;
using TestXamarinApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamarinApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel viewModel = new LoginViewModel();

        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            string _userName = "TarikBeg";
            string _password = "123";

            if (_userName == name.Text && _password == password.Text)
            {
                IsBusy = false;
                await viewModel.NavigationService.PushAsync(PageUrls.MenuView);
            }
            else
            {
                await DisplayAlert("This username/password combination isn't known",
                    "Error logging you in",
                    "OK");
            }
        }
    }
}