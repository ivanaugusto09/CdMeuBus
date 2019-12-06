using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Android.Factories;
using AndroidBitmapDescriptor = Android.Gms.Maps.Model.BitmapDescriptor;
using AndroidBitmapDescriptorFactory = Android.Gms.Maps.Model.BitmapDescriptorFactory;

namespace CadeMeuBus.Droid
{
    public sealed class AccessNativeBitmapConfig : IBitmapDescriptorFactory
    {
        public AndroidBitmapDescriptor ToNative(BitmapDescriptor descriptor)
        {
            int resId = 0;
            switch (descriptor.Id)
            {
                case "type1":
                    resId = Resource.Drawable.terminal1;
                    break;
                case "type2":
                    resId = Resource.Drawable.pinBus2;
                    break;
                case "type3":
                    resId = Resource.Drawable.bus1;
                    break;
            }

            return AndroidBitmapDescriptorFactory.FromResource(resId);
        }
    }
}