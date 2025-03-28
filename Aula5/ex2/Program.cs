Console.WriteLine("Tente descobrir o número secreto de 1 a 100!");
int chute = Convert.ToInt32(Console.ReadLine());
Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);
int tentativas = 0;

do {
    Console.WriteLine("Qual será o chute? ");
    chute = Convert.ToInt32(Console.ReadLine());
    tentativas++;

    if (chute < valorInteiro){
        Console.WriteLine("Muito baixo!");
    } else if (chute > valorInteiro){
        Console.WriteLine("Muito alto!");
    } else if(chute == valorInteiro){
        Console.WriteLine("Parabéns, você acertou!");
        Console.WriteLine($"Você precisou de {tentativas} tentativas.");
    }
} while (chute != valorInteiro);
