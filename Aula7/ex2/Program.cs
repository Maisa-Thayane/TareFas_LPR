Console.WriteLine("Digite 10 números inteiros separados por espaço:");
string? entrada = Console.ReadLine();

if (string.IsNullOrWhiteSpace(entrada))
{
    Console.WriteLine("Entrada inválida. Encerrando o programa.");
    return;
}

string[] partes = entrada.Split(' ', StringSplitOptions.RemoveEmptyEntries); // Para remover espaços vazios, ok?

if (partes.Length != 10)
{
    Console.WriteLine("Você deve digitar exatamente 10 números.");
    return;
}

int[] numeros = new int[10];
for (int i = 0; i < 10; i++)
{
    if (!int.TryParse(partes[i], out numeros[i])) // (!) Converte, armazena e verifica se deu certo, capiche?
    {
        Console.WriteLine("Entrada inválida. Encerrando o programa.");
        return;
    }
}

Console.WriteLine("Qual número deseja procurar?");
string? procurarStr = Console.ReadLine(); // Um nome é para o valor original e o outro é para a sua conversão, all right?

if (!int.TryParse(procurarStr, out int procurar))
{
    Console.WriteLine("Entrada inválida para número de procura. Encerrando programa.");
    return;
}

int encontrado = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == procurar)
    {
        Console.WriteLine($"O número {procurar} foi encontrado na posição {i}.");
        encontrado++;
    }
}

Console.WriteLine($"O número {procurar} foi encontrado {encontrado} vez(es) no array.");
