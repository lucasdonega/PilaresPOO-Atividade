namespace Exercicios_Heranca_cs
{
    public abstract class Jogo
    {
        public string? Nome { get; set; }
        protected string? Plataforma;

        public Jogo(string nome, string plataforma)
        {
            Nome = nome;
            Plataforma = plataforma;
        }


        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"{Nome}, {Plataforma}");
        }

    
    }
}