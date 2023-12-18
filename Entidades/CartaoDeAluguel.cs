using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAluguel.Entities
{
    internal class CartaoDeAluguel
    {
        public DateTime DataAluguel;
        public DateTime DataEntrega;
        public string placaVeiculo;
        public string CPFCliente;
        public double quilometragem;
        public decimal valorCalcao;
        public decimal valorLocacao;
        public bool foiDevolvido;


        public void geraCartaoAlguel()
        {
            var cartao = new CartaoDeAluguel();
            cartao.DataAluguel = DateTime.Now;
            Console.WriteLine("Digite a placa Do veiculo que deseja alugar");
            cartao.placaVeiculo = Console.ReadLine();

            Console.WriteLine("Digite o CPF do usuario que deseja alugar");
            cartao.placaVeiculo = Console.ReadLine();

        }
    }
}
