namespace Exercicios_Heranca_cs
{
    public class JogoFisico : Jogo
    {

        public int Peso { get; set; }

         public JogoFisico(string nome, string plataforma, int peso) : base (nome, plataforma)
        {
            Peso = peso;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Jogo Físico: ");
            base.ExibirInformacoes();
            Console.WriteLine($"Peso do jogo: {Peso} g.");
        }
    
    }
} 