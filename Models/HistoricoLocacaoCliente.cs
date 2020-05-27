using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HistoricoLocacaoCliente
    {
        public string Nome { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public decimal ValorPago { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }
    }
}
