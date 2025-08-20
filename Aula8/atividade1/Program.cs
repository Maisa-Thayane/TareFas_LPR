using System;

// Define uma estrutura (struct) chamada Produto
struct Produto
{
    public string Nome;      // Nome do produto
    public int Codigo;       // Código identificador do produto
    public double Preco;     // Preço unitário do produto
    public int Quantidade;   // Quantidade em estoque
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3]; // Cria um array para armazenar 3 produtos

        // Loop para ler os dados dos 3 produtos
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Digite os dados do produto {i + 1}:");

            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine(); // Lê o nome do produto

            Console.Write("Código: ");
            produtos[i].Codigo = int.Parse(Console.ReadLine()); // Lê o código

            Console.Write("Preço: ");
            produtos[i].Preco = double.Parse(Console.ReadLine()); // Lê o preço

            Console.Write("Quantidade em estoque: ");
            produtos[i].Quantidade = int.Parse(Console.ReadLine()); // Lê a quantidade
        }

        double valorTotal = 0; // Variável para armazenar o valor total em estoque

        // Calcula o valor total de todos os produtos
        for (int i = 0; i < 3; i++)
        {
            valorTotal += produtos[i].Preco * produtos[i].Quantidade; // Preço * Quantidade
        }

        // Exibe o valor total em estoque
        Console.WriteLine($"\nO valor total em estoque é: R$ {valorTotal:F2}");
    }
}
