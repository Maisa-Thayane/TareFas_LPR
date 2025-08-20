// Exibe mensagem pedindo que o usuário digite 10 números inteiros separados por espaço
Console.WriteLine("Digite 10 numeros inteiros seprados por espaço: ");
string? entrada = Console.ReadLine(); // Lê a entrada do usuário como string

// Verifica se a entrada é nula
if (entrada == null)
{
    Console.WriteLine("Entrada nula! Encerrando o programa.");
    return; // Encerra o programa se não houver entrada
}

// Converte a string em um array de inteiros
// Split divide a string em partes separadas por espaço
// Select(int.Parse) converte cada parte em inteiro
// ToArray() transforma o resultado em um array de inteiros
int[] numeros = entrada.Split(' ').Select(int.Parse).ToArray();

// Cria arrays para armazenar números pares e ímpares
int[] pares = new int[10];
int[] impares = new int[10];
int indicePares = 0;   // Controla quantos pares foram adicionados
int indiceImpares = 0; // Controla quantos ímpares foram adicionados

// Verifica se o usuário digitou exatamente 10 números
if (numeros.Length != 10)
{
    Console.WriteLine("Você deve digitar exatamente 10 números!");
    return; // Encerra o programa se não forem 10 números
}

// Percorre todos os números digitados
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0) // Se o número for par
    {
        pares[indicePares] = numeros[i]; // Adiciona ao array de pares
        indicePares++;                   // Incrementa o índice de pares
    }
    else // Se o número for ímpar
    {
        impares[indiceImpares] = numeros[i]; // Adiciona ao array de ímpares
        indiceImpares++;                     // Incrementa o índice de ímpares
    }
}

// Exibe os números pares
Console.WriteLine("\nNúmeros pares:");
for (int i = 0; i < indicePares; i++)
{
    Console.WriteLine(pares[i]);
}

// Exibe os números ímpares
Console.WriteLine("\nNúmeros ímpares:");
for (int i = 0; i < indiceImpares; i++)
{
    Console.WriteLine(impares[i]);
}
