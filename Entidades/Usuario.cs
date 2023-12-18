using SistemaAluguel.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAluguel.Entities
{
    internal class Usuario
    {
        
        public string Nome;
        public string CPF;
        public string Genero;
        public string Telefone;
        public string Email;
        public string NumeroCartao;
        public string Endereco_Id;
        public string Senha;
        private dados dados = new dados();

        public void Cadastro()
        {
            Usuario novoUsuario = new Usuario();

            Console.WriteLine("Digite os dados do usuário:");

            Console.Write("Nome: ");
            novoUsuario.Nome = Console.ReadLine();

            Console.Write("CPF: ");
            novoUsuario.CPF = Console.ReadLine();

            Console.Write("Senha: ");
            novoUsuario.Senha = Console.ReadLine();

            Console.Write("Gênero: ");
            novoUsuario.Genero = Console.ReadLine();

            Console.Write("Telefone: ");
            novoUsuario.Telefone = Console.ReadLine();

            Console.Write("E-mail: ");
            novoUsuario.Email = Console.ReadLine();

            Console.Write("Número do Cartão: ");
            novoUsuario.NumeroCartao = Console.ReadLine();

            Console.Write("Endereço ID: ");
            novoUsuario.Endereco_Id = Console.ReadLine();

            dados.AdicionaUsuario(novoUsuario);
        }
    }
}
