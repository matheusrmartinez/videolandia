using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DevolucaoPendente
    {
        public string NomeCliente { get; set; }
        public string NomeItem { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }
        public int DiasAtrasados { get; set; }
    }
}
