using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Situacao
    {
        public int CodigoSituacao { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataRetirada { get; set; }
        public DateTime DataPrevista { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    }
}
