// Pede ao usuário para digitar 10 números inteiros separados por espaço
Console.WriteLine("Digite 10 números inteiros separados por espaço:");
string? entrada = Console.ReadLine(); // Lê a entrada como string

// Verifica se a entrada é nula, vazia ou apenas espaços
if (string.IsNullOrWhiteSpace(entrada))
{
    Console.WriteLine("Entrada inválida. Encerrando o programa.");
    return; // Encerra o programa
}

// Divide a string em partes usando espaço como separador
// Remove espaços vazios extras com StringSplitOptions.RemoveEmptyEntries
string[] partes = entrada.Split(' ', StringSplitOptions.RemoveEmptyEntries); 

// Verifica se o usuário digitou exatamente 10 números
if (partes.Length != 10)
{
    Console.WriteLine("Você deve digitar exatamente 10 números.");
    return; // Encerra o programa
}

// Cria um array para armazenar os 10 números convertidos
int[] numeros = new int[10];
for (int i = 0; i < 10; i++)
{
    // Converte cada parte para inteiro usando TryParse
    // TryParse retorna true se a conversão der certo, e false caso contrário
    if (!int.TryParse(partes[i], out numeros[i])) // (!) Converte e verifica
    {
        Console.WriteLine("Entrada inválida. Encerrando o programa.");
        return; // Encerra o programa se houver erro de conversão
    }
}

// Pergunta qual número o usuário deseja procurar
Console.WriteLine("Qual número deseja procurar?");
string? procurarStr = Console.ReadLine(); // Lê o valor digitado como string

// Converte a entrada de procura para inteiro usando TryParse
if (!int.TryParse(procurarStr, out int procurar))
{
    Console.WriteLine("Entrada inválida para número de procura. Encerrando programa.");
    return; // Encerra o programa se a conversão falhar
}

// Variável para contar quantas vezes o número foi encontrado
int encontrado = 0;

// Percorre o array procurando o número
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == procurar) // Se o número na posição i é igual ao número procurado
    {
        Console.WriteLine($"O número {procurar} foi encontrado na posição {i}.");
        encontrado++; // Incrementa contador
    }
}

// Exibe quantas vezes o número foi encontrado
Console.WriteLine($"O número {procurar} foi encontrado {encontrado} vez(es) no array.");
