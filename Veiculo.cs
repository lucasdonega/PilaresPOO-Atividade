namespace Exercicios_Heranca_cs
{
    public abstract class Veiculo 
    {
            public string? Marca { get; set; }
            public string? Modelo { get; set; }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
        }
    }
}