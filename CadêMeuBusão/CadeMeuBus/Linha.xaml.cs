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
    public partial class Linha : StackLayout
    {
        public Linha()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}