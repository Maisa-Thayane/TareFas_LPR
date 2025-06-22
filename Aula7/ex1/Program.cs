// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite 10 numeros inteiros seprados por espaço: ");
string? entrada = Console.ReadLine();

if (entrada == null)
{
    Console.WriteLine("Entrada nula! Encerrando o programa.");
    return;
}

int[] numeros = entrada.Split(' ').Select(int.Parse).ToArray();

int[] pares = new int[10];
int[] impares = new int[10];
int indicePares = 0;
int indiceImpares = 0;

if (numeros.Length != 10)
{
    Console.WriteLine("Você deve digitar exatamente 10 números!");
    return;
}

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
        {
            pares[indicePares] = numeros[i];
            indicePares++;
        }
        else
        {
            impares[indiceImpares] = numeros[i];
            indiceImpares++;
        }
}


    Console.WriteLine("\nNúmeros pares:");
for (int i = 0; i < indicePares; i++)
{
    Console.WriteLine(pares[i]);
}

    Console.WriteLine("\nNúmeros ímpares:");
for (int i = 0; i < indiceImpares; i++)
{
    Console.WriteLine(impares[i]);
}
    