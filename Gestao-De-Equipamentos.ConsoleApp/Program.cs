namespace Gestao_De_Equipamentos.ConsoleApp
{
    internal class Program
    {
        static Equipamento[] equipamentos = new Equipamento[100];
        static int contadorEquipamentos = 0;

        static void Main(string[] args)
        {
            TelaEquipamento telaEquipamento = new TelaEquipamento();

            while (true)
            {
                string opcaoEscolhida = telaEquipamento.ApresentarMenu();

                switch (opcaoEscolhida)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Gestão de equipamentos");
                        Console.WriteLine("----------------------");

                        Console.WriteLine("Cadastrando equipamento");

                        Console.Write("Digite o nome do equipamento.");
                        string nome = Console.ReadLine()!;

                        Console.Write("Digite o nome do fabricante.");
                        string Fabricante = Console.ReadLine()!;

                        Console.Write("Digite o preço da aquisição:R$");
                        decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine())!;

                        Console.Write("Digite a data de fabricacao do equipamento: (dd/mm/yyyy)");
                        DateTime dataFabricacao = Convert.ToDateTime(Console.ReadLine());

                        Equipamento equipamento = new Equipamento(nome, Fabricante, precoAquisicao, dataFabricacao);

                        equipamentos[contadorEquipamentos++] = equipamento;

                        break;

                    case "4":

                        Console.Clear();
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Gestão de equipamentos");
                        Console.WriteLine("----------------------");

                        Console.WriteLine("4- Visualização de equipamentos");
                        Console.WriteLine("----------------------");

                        //Cabecalho tabela
                        Console.WriteLine("{0, -10}| {1, -15} | {2,-11}| {3,-15}| {4,-15} | {5, -10} , ...." +
                            "Id", "Nome", "Num.Serie", "Fabricante", "Preço", "Data de Fabricação");

                        for (int i = 0; i < equipamentos.Length; i++)
                        {
                            Equipamento e = equipamentos[i];

                            if (e == null) continue;
                            Console.WriteLine("{0, -10}| {1, -15} | {2,-11}| {3,-15}| {4,-15} | {5, -10} , ...." +
                             e.Id, e.Nome, e.ObterNumeroSerie(), e.Fabricante, e.precoAquisicao.ToString("C2"), e.DataDeFabricacao.ToShortDateString());

                        }
                        break;






                    default:
                        Console.WriteLine("Saindo do programa...");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
