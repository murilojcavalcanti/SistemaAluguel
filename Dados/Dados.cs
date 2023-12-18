using SistemaAluguel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAluguel.Dados;

internal class dados
{

    private List<Veiculo> _Veiculos = new List<Veiculo>();
    private List<Veiculo> _VeiculosAlugados = new List<Veiculo>();
    private List<Veiculo> _VeiculosDisponiveis = new List<Veiculo>();
    private List<Usuario> _Clientes = new List<Usuario>();
    private List<Endereço> _Endereços = new List<Usuario>();
    private List<CartaoDeAluguel> _CartaoDeAluguel = new List<CartaoDeAluguel>();

    public dados()
    {
        var veiculo1 = new Veiculo
        {
            Modelo = "Sedan",
            Ano = new DateTime(2020, 1, 1),
            Placa = "ABC1234",
            NumeroPortas = 4,
            TipoCombustivel = "Gasolina",
            Marca = "Marca A",
            EstaAlugado = false,
            ValorDiaria = 100.50m
        };

        var veiculo2 = new Veiculo
        {
            Modelo = "Hatchback",
            Ano = new DateTime(2019, 1, 1),
            Placa = "DEF5678",
            NumeroPortas = 5,
            TipoCombustivel = "Etanol",
            Marca = "Marca B",
            EstaAlugado = true,
            ValorDiaria = 90.25m
        };
        var veiculo3 = new Veiculo
        {
            Modelo = "SUV",
            Ano = new DateTime(2021, 1, 1),
            Placa = "GHI9012",
            NumeroPortas = 5,
            TipoCombustivel = "Diesel",
            Marca = "Marca C",
            EstaAlugado = false,
            ValorDiaria = 120.75m
        };

        var veiculo4 = new Veiculo
        {
            Modelo = "Caminhão",
            Ano = new DateTime(2018, 1, 1),
            Placa = "JKL3456",
            NumeroPortas = 2,
            TipoCombustivel = "Diesel",
            Marca = "Marca D",
            EstaAlugado = true,
            ValorDiaria = 150.00m
        };
        var veiculo5 = new Veiculo
        {
            Modelo = "Coupé",
            Ano = new DateTime(2022, 1, 1),
            Placa = "MNO7890",
            NumeroPortas = 2,
            TipoCombustivel = "Gasolina",
            Marca = "Marca E",
            EstaAlugado = false,
            ValorDiaria = 200.00m
        };
        var cartaoCarro4 = new CartaoDeAluguel
        {
            DataAluguel = DateTime.Now,
            DataEntrega = DateTime.Now.AddDays(5),
            foiDevolvido = false,
            placaVeiculo = "JKL3456",
            CPFCliente = "12345678911",
            quilometragem = 25678,
            valorCalcao = 300m,
            valorLocacao = 650m
        };

        var cartaoCarro2 = new CartaoDeAluguel
        {
            DataAluguel = DateTime.Now,
            DataEntrega = DateTime.Now.AddDays(5),
            foiDevolvido = false,
            placaVeiculo = "DEF5678",
            CPFCliente = "45612378911",
            quilometragem = 45678,
            valorCalcao = 230m,
            valorLocacao = 451m
        };
        _Veiculos.Add(veiculo1);
        _Veiculos.Add(veiculo2);
        _Veiculos.Add(veiculo3);
        _Veiculos.Add(veiculo4);
        _Veiculos.Add(veiculo5);


        _VeiculosAlugados.Add(veiculo4);
        _VeiculosAlugados.Add(veiculo2);

        _VeiculosDisponiveis.Add(veiculo1);
        _VeiculosDisponiveis.Add(veiculo3);
        _VeiculosDisponiveis.Add(veiculo5);

    }

    public void AdicionaVeiculos(Veiculo veiculo)
    {
        _Veiculos.Add(veiculo);
        AdicionaVeiculosDisponiveis(veiculo);
    }
    public  void AdicionaVeiculosDisponiveis(Veiculo veiculo)
    {
        _VeiculosDisponiveis.Add(veiculo);
    }

    public void AdicionaVeiculosAlugados(Veiculo veiculo)
    {
        _VeiculosAlugados.Add(veiculo);
    }

    public void AdicionaCartaoAluguel(CartaoDeAluguel cartaoAluguel)
    {
        _CartaoDeAluguel.Add(cartaoAluguel);
    }

    public void AdicionaUsuario(Usuario cliente)
    {
        _Clientes.Add(cliente);
    }

    public void AdicionaEndereco(Endereço end)
    {
        _Endereços.Add(end);
    }
}
