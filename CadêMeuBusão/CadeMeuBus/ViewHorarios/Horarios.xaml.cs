using CadeMeuBus.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CadeMeuBus.ViewHorarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Horarios : ContentPage
    {
        public Horarios()
        {
            InitializeComponent();
            
            BindingContext = new MapPageViewModel();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HorariosLinha());
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HorariosLinha());
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            
        }
    }
}