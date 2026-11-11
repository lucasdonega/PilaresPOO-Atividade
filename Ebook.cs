namespace Exercicios_Heranca_cs
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }

        public Ebook(string nome, int preco, int quantidadePaginas) : base(nome, preco)
        {
            QuantidadePaginas = quantidadePaginas;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Ebook:");
            
            base.ExibirInformacoes();
            Console.WriteLine($"Quantidade de páginas: {QuantidadePaginas}");
        }
    }
}