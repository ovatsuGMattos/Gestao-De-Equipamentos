using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao_De_Equipamentos.ConsoleApp
{
    public class TelaEquipamento
    {
        public string ApresentarMenu()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("Gestão de equipamentos");
            Console.WriteLine("----------------------");
            Console.WriteLine("Escolha a operação que desejar");
            Console.WriteLine("1- Cadastro de equipamentos");
            Console.WriteLine("4- Visualização de equipamentos");

            Console.WriteLine("----------------------");


            Console.WriteLine("Digite uma opção válida:");
            string opcaoEscolhida = Console.ReadLine()!;

            return opcaoEscolhida; 
        }
    }
}
