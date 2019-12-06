using CadeMeuBus.BD;
using CadeMeuBus.Model;
using CadeMeuBus.ViewHorarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadeMeuBus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {

        List<Usuario> Lista { get; set; }
        public MenuPage()
        {
            InitializeComponent();
            AcessoBD banco = new AcessoBD();
            //listagem.ItemsSource = banco.Consultar();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Horarios());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Problemas());
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CartãoCredito());
        }
    }
}