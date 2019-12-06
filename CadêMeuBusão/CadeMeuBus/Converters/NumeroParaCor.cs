using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;

namespace CadeMeuBus.Converters
{
    public class NumeroParaCor : Validacao, IValueConverter
    {

        public Color Visa { get; set; }
        public Color MasterCard { get; set; }
        public Color NotRecognized { get; set; }

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
