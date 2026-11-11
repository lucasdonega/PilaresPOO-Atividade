namespace Exercicios_Heranca_cs
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Tipo de veiculo: Carro");
            base.ExibirInformacoes();
            Console.WriteLine($"Portas: {QuantidadePortas}");
        }
    }
}