using System;
using System.Collections.Generic;

namespace Models
{
    public class Item
    {
        public int CodigoItem { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Titulo { get; set; }
        public List<GeneroFilme> GeneroFilmes { get; set; }
        public int Ano { get; set; }
        public string Tipo { get; set; }
        public double Preco { get; set; }
        public DateTime DataAquirida { get; set; }
        public double PrecoDeCusto { get; set; }
        public Situacao SituacaoFilme { get; set; }
        public List<Ator> Atores { get; set; }
        public Diretor Diretor { get; set; }
    }
}
