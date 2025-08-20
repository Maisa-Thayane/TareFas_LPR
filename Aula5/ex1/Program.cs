// Pede ao usuário quantos elementos serão digitados
Console.WriteLine("Digite a quantidade de elementos a serem contabilizados: ");
int quant = Convert.ToInt32(Console.ReadLine()); // Lê o número de elementos

// Cria um vetor (array) para armazenar todos os elementos digitados
int[] elementos = new int[quant];

Console.WriteLine("Liste os elementos da media: "); 

// Variáveis auxiliares
int acumulador = 0; // Vai somar apenas os números pares
int contagem = 0;   // Conta quantos números pares foram digitados
int i = 0;          // Controla o loop

// Estrutura de repetição while → repete até ler todos os elementos
while (i < quant) 
{
    Console.Write($"Elemento {i + 1}: "); // Mostra qual elemento o usuário deve digitar
    elementos[i] = Convert.ToInt32(Console.ReadLine()); // Lê e guarda no vetor

    // Verifica se o número digitado é par
    if (elementos[i] % 2 == 0) {
        acumulador += elementos[i]; // Soma no acumulador
        contagem++;                 // Conta +1 número par
    }

    i++; // Avança para o próximo índice
}

// Após o loop, verifica se houve números pares
if (contagem > 0) 
{
    // Calcula a média → soma dos pares dividido pela quantidade de pares
    double media = (double)acumulador / contagem;
    Console.WriteLine($"A média dos números pares é: {media}");
}
else
{
    // Caso nenhum número par tenha sido digitado
    Console.WriteLine("Não há números pares para calcular a média.");
}
