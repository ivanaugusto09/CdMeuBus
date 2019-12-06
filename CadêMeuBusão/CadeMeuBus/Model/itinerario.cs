using System;
using System.Collections.Generic;
using System.Text;

namespace CadeMeuBus.Model
{
    public class itinerario
    {
        public string Linha { get; set; }
        public string Saida { get; set; }
        public List<Detalhes> Detalhes { get; set; }

    }

    public class Detalhes
    {
        public string Preco { get; set; }
        public string Icon { get; set; }
        public string Tipo { get; set; }
        public string Info { get; set; }
    }

  

}
