using CadeMeuBus.BD;
using CadeMeuBus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadeMeuBus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Denuncia : ContentPage
    {

        
        public Denuncia()
        {
            InitializeComponent();
            Problemas problema = new Problemas();
        }



        private void Data_DateSelected(object sender, DateChangedEventArgs e)
        {
            lbldt.Text = Data.Date.AddDays(0).ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var message = new EmailMessage("Denúncias ou Problemas", nome.Text, "ivan.abt69@outlook.com");
            await Email.ComposeAsync(message);
        }
    }
}