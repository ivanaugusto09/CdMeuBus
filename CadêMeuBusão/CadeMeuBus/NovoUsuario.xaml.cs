using CadeMeuBus.BD;
using CadeMeuBus.Model;
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
    public partial class NovoUsuario : ContentPage
    {
        AcessoBD banco = new AcessoBD();
        public NovoUsuario()
        {
            InitializeComponent();
        }

        private async void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtNovoUsuario.Text)) || (string.IsNullOrWhiteSpace(txtSenhaNovoUsuario.Text)) ||
               (string.IsNullOrEmpty(txtNovoUsuario.Text)) || (string.IsNullOrEmpty(txtSenhaNovoUsuario.Text)))
            {
                await DisplayAlert("Alerta", "Um ou Mais Campos Estão Vazios", "OK");
            }
            else
            {
                Usuario login = new Usuario();
                login.usuario = txtNovoUsuario.Text;
                login.senha = txtSenhaNovoUsuario.Text;
                login.idade = idade.Text;
                login.sexo = pk.ToString();

                try
                {
                    var returnvalor = banco.Inserir(login);
                    if (returnvalor == "Usuário Cadastrado Com Sucesso!")
                    {
                        await DisplayAlert("Sucesso", returnvalor, "OK");

                        await Navigation.PushAsync(new MainPage());

                    }

                    else
                    {
                        await DisplayAlert("Alerta", returnvalor, "OK");

                        txtNovoUsuario.Text = "";
                        txtSenhaNovoUsuario.Text = "";
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void Pk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}