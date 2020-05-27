using System;
using System.Collections.Generic;

namespace Models
{
    public class Locacao
    {
        public int CodigoLocacao { get; set; }
        public Item Item { get; set; }
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataAtual { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPrevista { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorPago { get; set; }
        public string SituacaoPagamento { get; set; }
        public List<ItemLocacao> ItensLocacao { get; set; }

    }
}
