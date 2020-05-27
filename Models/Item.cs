using System;
using System.Collections.Generic;

namespace Models
{
    public class Item
    {
        public int CodigoItem { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Titulo { get; set; }
        public Genero GeneroFilme { get; set; }
        public int Ano { get; set; }
        public string Tipo { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataAdquirida { get; set; }
        public decimal Custo { get; set; }
        public int CodigoSituacaoFilme { get; set; }
        public List<Artista> Artistas { get; set; } 
    }
}
