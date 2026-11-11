namespace Exercicios_Heranca_cs
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Tipo de veiculo: Motocicleta");
            base.ExibirInformacoes();
            Console.WriteLine($"Cilindradas: {Cilindradas}");
        }
    }
}