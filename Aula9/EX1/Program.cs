using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Cria uma lista dinâmica para armazenar nomes
        List<string> nomes = new();

        // Solicita ao usuário o tamanho da lista
        Console.WriteLine("Digite o tamanho da lista: ");
        int tamanho = int.Parse(Console.ReadLine());

        // Loop para preencher a lista com nomes
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine("Digite o nome: ");
            string n = Console.ReadLine(); // Lê o nome digitado
            nomes.Add(n);                  // Adiciona o nome à lista
        }

        // Aqui havia um "while" sem condição, removido para evitar erro

        // Exibe todos os nomes da lista
        for (int i = 0; i < nomes.Count; i++)
        {
            Console.WriteLine(nomes[i]);
        }
    }
}
