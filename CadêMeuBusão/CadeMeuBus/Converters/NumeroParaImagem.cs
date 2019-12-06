using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace CadeMeuBus.Converters
{
    public class NumeroParaImagem : Validacao, IValueConverter
    {
        public ImageSource Visa { get; set; }
        public ImageSource MasterCard { get; set; } 
        public ImageSource NotRecognized { get; set; }


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return NotRecognized;

            var number = value.ToString();
            var numberNormalized = number.Replace("-", string.Empty);

            if (visaRegex.IsMatch(numberNormalized)) return Visa;

            if (masterRegex.IsMatch(numberNormalized)) return MasterCard;
    
            return NotRecognized;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
