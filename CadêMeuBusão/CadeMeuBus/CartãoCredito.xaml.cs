using CadeMeuBus.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadeMeuBus
{
    [DesignTimeVisible(false)]
    public partial class CartãoCredito : ContentPage
    {
        public CartãoCredito()
        {
            InitializeComponent();
            this.BindingContext = new CartaoCredito();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Sucesso", "Passagem Paga", "OK");
        }
    }
}