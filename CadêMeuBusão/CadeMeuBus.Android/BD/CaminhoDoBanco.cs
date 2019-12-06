using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CadeMeuBus.Droid.BD;
using CadeMeuBus.BD;
using Xamarin.Forms;

[assembly: Dependency(typeof(CaminhoDoBanco))]
namespace CadeMeuBus.Droid.BD
{
    public class CaminhoDoBanco : I_LocalDados
    {
        public string getCaminho(string nomedoarquivo)
        {
            string path = System.Environment.GetFolderPath(
            System.Environment.SpecialFolder.Personal);
            string arquivo = Path.Combine(path, nomedoarquivo);
            return arquivo;
        }
    }
}