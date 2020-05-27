namespace Models
{
    public class ItemLocacao
    {
        public int CodigoLocacao { get; set; }
        public int CodigoItem { get; set; }
        public string CodigoDeBarras { get; set; }
        public decimal Valor { get; set; }
        public string Titulo { get; set; }
    }
}
