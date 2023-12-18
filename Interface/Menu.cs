using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAluguel.Interface
{
    internal class Menu
    {
        public static void ApresentaMenuPrincipal()
        {
            Console.WriteLine("Bem-vindo ao LoCar, O que deseja fazer?");
            Console.WriteLine("Digite 1 para realizar o login");
            Console.WriteLine("Digite 2 para cadastrar um veiculo");
            Console.WriteLine("Digite 3 para consultar alugueis");
        }
        public static void EscolhaMenuPrincipal(int op)
        {
            switch (op)
            {
                case 1:
                    Console.WriteLine();
                        break;
                case 2:
                    Console.WriteLine();
                        break;
                case 3:
                    Console.WriteLine();
                        break;            }

        }

        public static void ApresentaMenuLogin()
        {
            Console.WriteLine("Bem-vindo ao LoCar, O que deseja fazer?");
            Console.WriteLine("Digite 1 para realizar aluguel");
            Console.WriteLine("Digite 2 para cadastrar um cartão");
            Console.WriteLine("Digite 3 para consultar alugueis");
        }
        public static void EscolhaMenuLogin(int op)
        {
            switch (op)
            {
                case 1:
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
            }

        }

    }
}
