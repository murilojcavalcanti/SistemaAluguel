using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAluguel.Entities
{
    internal class Endereço
    {
        [Key]
        public int ID;
        public string CEP;
        public string Rua;
        public string numero;
        public string cidade;
        public string Estado;


        public void cadastrarEndereco()
        {
            Endereço end = new Endereço();

            Console.Write("Digite o CEP: ");
            end.CEP = Console.ReadLine();

            Console.Write("Digite o nome da rua: ");
            end.Rua = Console.ReadLine();

            Console.Write("Digite o numero: ");
            end.numero = Console.ReadLine();

            Console.Write("Digite o nome da Cidade: ");
            end.cidade = Console.ReadLine();

            Console.Write("Digite o nome do Estado: ");
            end.Estado = Console.ReadLine();


        }


    }
}
