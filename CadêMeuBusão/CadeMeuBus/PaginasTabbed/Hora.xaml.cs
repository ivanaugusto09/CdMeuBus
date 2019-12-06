using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CadeMeuBus.Model;
using CadeMeuBus.ViewModel;

namespace CadeMeuBus.PaginasTabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hora : ContentPage
    {
        public Hora()
        {
            InitializeComponent();

           horarios.ItemsSource = new List<Horas>
            {
                new Horas { Id=1, HoraLinha="04:50" },
                new Horas { Id=2, HoraLinha="04:45" },
                new Horas { Id=3, HoraLinha="05:15" },
                new Horas { Id=4, HoraLinha="05:40" },
                new Horas { Id=5, HoraLinha="05:55" },
                new Horas { Id=6, HoraLinha="06:20" },
                new Horas { Id=7, HoraLinha="07:00" },
                new Horas { Id=8, HoraLinha="07:40" },
                new Horas { Id=9, HoraLinha="08:10" }

            };

        }
    }
}