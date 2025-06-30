using System;

using System.Collections.Generic;

class Exemplo
{
    static void Main()
    {
        int superiores = 0;
        int repeticoes = 0;
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

        numeros.Add(4);
        numeros.Insert(2, 7);

        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] == 8)
            {
                Console.WriteLine("Sim, o numero 8 foi encontrado.");
            }
        }
        for (int i = 0; i < numeros.Count; i++)
        {
            while (numeros[i] > 4)
            {
                superiores++;
            }
        }
        Console.WriteLine("A quantidade de numeros maiores que 4: ");
        Console.WriteLine(superiores);

        for (int i = 0; i < numeros.Count; i++)
        {
            while (numeros[i] == 3)
            {
                repeticoes++;
            }
        }
        Console.WriteLine("A quantidade de vezes em que 3 apareceu: ");
        Console.WriteLine(repeticoes);
        for(int i = 0; i < numeros.Count; i++){
        while (numeros[i] == 4)
        {
            numeros.Remove(4);
        }
        }
        numeros.Remove(2);
    }
}