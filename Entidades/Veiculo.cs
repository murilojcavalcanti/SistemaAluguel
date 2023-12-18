using SistemaAluguel.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAluguel.Entities
{
    public class Veiculo
    {
        public string Cor;
        public string Modelo;
        public DateTime Ano;
        public string Placa;
        public int NumeroPortas;
        public string TipoCombustivel;
        public string Marca;
        public bool EstaAlugado;
        public decimal ValorDiaria;

        private dados dados = new dados();
        public void CadastraVeiculos()
        {
            Veiculo veiculo = new Veiculo();
            
            Console.Write("Digite a placa do carro: ");
            veiculo.Placa = Console.ReadLine();
            
            Console.Write("Digite o Modelo do carro: ");
            veiculo.Modelo = Console.ReadLine();
            
            Console.Write("Digite a marca do carro: ");
            veiculo.Marca = Console.ReadLine();
            
            Console.WriteLine("Digite o ano do carro: Ex: 01/01/2000");
            veiculo.Ano = DateTime.Parse(Console.ReadLine());
            
            Console.Write("Digite a cor do carro: ");
            veiculo.Cor = Console.ReadLine();
            
            Console.Write("Digite o numero de portas do carro: ");
            int.TryParse(Console.ReadLine(), out veiculo.NumeroPortas);
            
            Console.Write("Digite o valor da diaria do carro: ");
            decimal.TryParse(Console.ReadLine(), out veiculo.ValorDiaria);

            veiculo.EstaAlugado = false;
            dados.AdicionaVeiculos(veiculo);

        }
    }
}
