using System;

namespace Models
{
    public class Devolucao
    {
        public Locacao Locacao { get; set; }
        public DateTime DataEntrega { get; set; }
        public decimal ValorAPagar { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
