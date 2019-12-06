using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CadeMeuBus.Model
{
    [Table("Usuario")]
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(25)]
        public string usuario { get; set; }

        [MaxLength(15)]
        public string senha { get; set; }

        public string idade { get; set; }

        public string sexo { get; set; }

    }
}
