using System.Security.Cryptography.X509Certificates;

namespace Exercicios_Heranca_cs
{
    public abstract class ProdutoDigital
    {
        public string? Nome { get; set; }
        public int Preco { get; set; }

        public ProdutoDigital(string nome, int preco)
        {
            Nome = nome;
            Preco = preco;
            
            
        }
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Preco: {Preco:C}");
        }
    }
}