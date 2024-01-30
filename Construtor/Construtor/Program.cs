﻿using Construtor;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        Produto p = new Produto("Tv", 500.00, 10);

        Console.WriteLine("Entre os dados do produto:");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Quantidade no estoque: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto produto = new Produto(nome, preco, quantidade);

        Console.WriteLine();

        Console.WriteLine("Dados do produto: " + produto);
        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        produto.AdicionarProdutos(qte);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + produto);
        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        produto.RemoverProdutos(qte);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + produto);

    }
}