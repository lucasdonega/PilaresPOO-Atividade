namespace Exercicios_Heranca_cs
{
    public class JogoDigital : Jogo
    {

        public int TamanhoDoJogo { get; set; }


        public JogoDigital(string nome, string plataforma, int tamanhoDoJogo) : base(nome, plataforma)
        {
            TamanhoDoJogo = tamanhoDoJogo;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Jogo Digital: ");
            base.ExibirInformacoes();
            Console.WriteLine($"Tamanho do jogo: {TamanhoDoJogo} gigabytes.");
        }
    }
}