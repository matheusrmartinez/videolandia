using System.Collections.Generic;

namespace Models
{
    public class GeneroFilme
    {
        public List<int> CodigoGenero { get; set; }
        public int CodigoItem { get; set; }
        public string Titulo { get; set; }
        public string CodigoDeBarras { get; set; }
        public List<string> NomeGenero { get; set; }
    }
}
