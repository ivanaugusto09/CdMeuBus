﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadeMeuBus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Problemas : ContentPage
    {
        public Problemas()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Denuncia());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Denuncia());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Denuncia());
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Denuncia());
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Denuncia());
        }

        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomMasterDetailPage());
        }

        private async void Button_Clicked_6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Denuncia());
        }
    }
}