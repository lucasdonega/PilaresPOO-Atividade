namespace Exercicios_Heranca_cs
{
    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursoOnline(string nome, int preco, int cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("Curso Online: ");
            base.ExibirInformacoes();
            Console.WriteLine($"Carga Horária: {CargaHoraria} Horas");
        }
    }
}