namespace WorkerSample.Domain.Model
{
    public class Product
    {
        public int Codigo { get; set; }
        public string? Categoria { get; set; }
        public string? Tipo { get; set; }
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string? Estado { get; set; }
    }
}
