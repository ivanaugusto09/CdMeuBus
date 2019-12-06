using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CadeMeuBus.Model;

namespace CadeMeuBus.PaginasTabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Itinera : ContentPage
    {
        public Itinera()
        {
            InitializeComponent();

            itinerarios.ItemsSource = new List<Horas>
            {
                new Horas { Rua="AVENIDA JÚLIO CAMPOS", Bairro="CENTRO" },
                new Horas { Rua="AVENIDA DAS EMBAÚBAS", Bairro="CENTRO" },
                new Horas { Rua="AVENIDA DAS ITAÚBAS", Bairro="CENTRO" },
                new Horas { Rua="AVENIDA DOS TARUMÃS", Bairro="SETOR COMERCIAL" },
                new Horas { Rua="AVENIDA DOS JACARANDAS", Bairro="JARDIM BOTÂNICO" },
                new Horas { Rua="RUA ALBERTO BARANJAK", Bairro="JARDIM SANTA MÔNICA" },
                new Horas { Rua="BR163", Bairro="" },


            };
        }
    }
}