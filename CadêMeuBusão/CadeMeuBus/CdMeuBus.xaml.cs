using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;
using CadeMeuBus;
using CadeMeuBus.ViewModel;

namespace CadeMeuBus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CdMeuBus : ContentPage
    {
        public CdMeuBus()
        {
            InitializeComponent();
            AddMapStyle();
            BindingContext = new MapPageViewModel();


            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                              new Position(-11.853893, -55.510112),
                              Distance.FromMiles(0.5)));




            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-11.855177, -55.496813),
                Label = "Sinop",
                Address = "Ponto de Onibus",
                Icon = BitmapDescriptorFactory.FromBundle("type2")

            };

            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-11.855345, -55.506999),
                Label = "Sinop",
                Address = "Ponto de Onibus",
                Icon = BitmapDescriptorFactory.FromBundle("type2")

            };

            var pin3 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-11.861996, -55.513672),
                Label = "Sinop",
                Address = "Ponto de Onibus",
                Icon = BitmapDescriptorFactory.FromBundle("type2")
               

            };

            var pin4 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-11.851308, -55.511864),
                Label = "Sinop",
                Address = "Ponto de Onibus",
                Icon = BitmapDescriptorFactory.FromBundle("type2")

            };

            var pin5 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-11.847490, -55.508309),
                Label = "Sinop",
                Address = "Ponto de Onibus",
                Icon = BitmapDescriptorFactory.FromBundle("type2")

            };


            var pin6 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-11.851884, -55.519618),
                Label = "Sinop",
                Address = "Ponto de Onibus",
                Icon = BitmapDescriptorFactory.FromBundle("type2")

            };

            var pin7 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-11.854567, -55.519877),
                Label = "Sinop",
                Address = "Ponto de Onibus",
                Icon = BitmapDescriptorFactory.FromBundle("type2")

            };

            var terminal = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-11.853893, -55.510112),
                Label = "Sinop",
                Address = "Terminal Municipal",
                Icon = BitmapDescriptorFactory.FromBundle("type1")

            };

            var bus = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-11.848739, -55.508653),
                Label = "Ônibus",
                Address = "Ônibus em Andamento",
                Icon = BitmapDescriptorFactory.FromBundle("type3")

            };

            var bus1 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-11.856343, -55.502721),
                Label = "Ônibus",
                Address = "Ônibus em Andamento",
                Icon = BitmapDescriptorFactory.FromBundle("type3")

            };

            map.Pins.Add(terminal);
            map.Pins.Add(bus);
            map.Pins.Add(bus1);
            map.Pins.Add(pin7);
            map.Pins.Add(pin6);
            map.Pins.Add(pin5);
            map.Pins.Add(pin4);
            map.Pins.Add(pin3);
            map.Pins.Add(pin);
            map.Pins.Add(pin2);

            map.MyLocationEnabled = true;
            map.UiSettings.MyLocationButtonEnabled = true;
            map.UiSettings.CompassEnabled = false;

            void AddMapStyle()
            {
                var assembly = typeof(CdMeuBus).GetTypeInfo().Assembly;
                var stream = assembly.GetManifestResourceStream($"CadeMeuBus.MapStyle.json");
                string text;
                using (var reader = new System.IO.StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                }

                map.MapStyle = MapStyle.FromJson(text);
            }

            
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            CustomMasterDetailPage.Current.IsPresented = true;
        }

        
    }
}