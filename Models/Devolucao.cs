using System;

namespace Models
{
    public class Devolucao
    {
        public Locacao Locacao { get; set; }
        public DateTime DataEntrega { get; set; }
        public double ValorAPagar { get; set; }
        public double ValorPago { get; set; }
    }
}
