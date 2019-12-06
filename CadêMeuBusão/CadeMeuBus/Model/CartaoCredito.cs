using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CadeMeuBus.Model
{
    public class CartaoCredito : INotifyPropertyChanged
    {
        public string Numero { get; set; }
        public string Cvv { get; set; }
        public string Validade { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
