using CadeMeuBus.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CadeMeuBus
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        AcessoBD bd;
        public MainPage()
        {
            InitializeComponent();
            bd = new AcessoBD();
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "") && (txtSenha.Text == "") || (txtUsuario.Text == "") || (txtSenha.Text == ""))
            {
                await DisplayAlert("Alerta", "Usuário e/ou senha vazios!", "OK");
            }

            else if (txtUsuario.Text != null && txtSenha.Text != null)
            {
                var validData = bd.LoginValidate(txtUsuario.Text, txtSenha.Text);
                if (validData)
                {
                    await Navigation.PushAsync(new CustomMasterDetailPage());
                }
                else
                {
                    await DisplayAlert("Login Failed", "Usuário ou Senha Incorretos", "OK");
                }
            }

        }

        private async void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NovoUsuario());
        }
    }
}
