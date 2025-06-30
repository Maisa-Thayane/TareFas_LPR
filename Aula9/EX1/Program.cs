using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> nomes = new();

        Console.WriteLine("Digite o tamanho da lista: ");
        int tamanho = int.Parse(Console.ReadLine());
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine("Digite o nome: ");
            string n = Console.ReadLine();
            nomes.Add(n);
        }
        while
        for (int i = 0; i < nomes.Count; i++)
        {
            Console.WriteLine(nomes[i]);
        }
    }
}
