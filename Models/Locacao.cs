using System;
using System.Collections.Generic;

namespace Models
{
    public class Locacao
    {
        public Item Item { get; set; }
        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataAtual { get; set; }
        public double Valor { get; set; }
        public DateTime DataPrevista { get { return DateTime.Now.AddDays(5);} }
        public double ValorTotal { get; set; }
        public double ValorPago { get; set; }
        public string Situacao { get; set; }
    }
}
