// Exibe mensagem inicial para o jogador
Console.WriteLine("Tente descobrir o número secreto de 1 a 100!");

// Lê o primeiro chute (não é tão necessário aqui, mas você já inicia a variável)
int chute = Convert.ToInt32(Console.ReadLine());

// Cria um gerador de números aleatórios
Random numAleatorio = new Random();

// Gera um número inteiro aleatório entre 1 e 100
int valorInteiro = numAleatorio.Next(1, 100);

// Contador de tentativas
int tentativas = 0;

// Estrutura de repetição "do...while"
// O jogador vai continuar tentando até acertar o número secreto
do {
    Console.WriteLine("Qual será o chute? ");
    chute = Convert.ToInt32(Console.ReadLine()); // Lê o chute do usuário
    tentativas++; // Aumenta o número de tentativas

    // Dá dicas dependendo do chute
    if (chute < valorInteiro){
        Console.WriteLine("Muito baixo!");
    } else if (chute > valorInteiro){
        Console.WriteLine("Muito alto!");
    } else if (chute == valorInteiro){
        Console.WriteLine("Parabéns, você acertou!");
        Console.WriteLine($"Você precisou de {tentativas} tentativas.");
    }

// Continua repetindo até o chute ser igual ao número secreto
} while (chute != valorInteiro);
