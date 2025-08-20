using System.ComponentModel;           // Importa recursos relacionados a componentes (não está sendo usado aqui).
using System.Runtime.CompilerServices; // Importa utilitários de compilador (também não está sendo usado neste código).

// Pergunta o nome do personagem favorito
Console.WriteLine("Qual o nome do seu personagem favorito?");
string? name = Console.ReadLine(); // Lê a resposta do usuário e armazena na variável 'name'

// Pergunta a obra em que o personagem aparece
Console.WriteLine("Qual o nome do filme/serie/jogo que esse personagem faz parte?");
string? assunto = Console.ReadLine(); // Armazena a obra em 'assunto'

// Pergunta a idade do personagem
Console.WriteLine("Qual a idade dele?");
int idade = Convert.ToInt32(Console.ReadLine()); // Converte a entrada de texto em número inteiro

// Declaração de variáveis auxiliares (usadas depois conforme a escolha do usuário)
int vezes;        // Quantas vezes assistiu o filme
double finalizar; // Tempo para finalizar o jogo
float duracao;    // Duração do filme em horas
int repetiu;      // Quantas vezes jogou novamente
int nota;         // Nota atribuída ao personagem/obra

// Pergunta se é um filme (1 = sim, 2 = não)
Console.WriteLine("É um filme? Digite '1' para verdadeiro e '2' para falso.");
int filme = Convert.ToInt32(Console.ReadLine());

// Se for filme
if (filme == 1) {
    Console.WriteLine("Qual o tempo de duração do filme? Em horas.");
    duracao = Convert.ToInt32(Console.ReadLine()); // Lê duração em horas

    Console.WriteLine("Quantas vezes ja assistiu?");
    vezes = Convert.ToInt32(Console.ReadLine());   // Lê quantas vezes assistiu
} else {
    // Se não for filme, considera que é jogo
    Console.WriteLine("Quanto tempo levou para terminar o jogo?");
    finalizar = Convert.ToInt32(Console.ReadLine()); // Lê o tempo para finalizar o jogo

    Console.WriteLine("Quantas vezes ja jogou?");
    repetiu = Convert.ToInt32(Console.ReadLine());   // Lê quantas vezes jogou
}

// Pergunta se recomendaria a outra pessoa
Console.WriteLine("Voce recomendaria para outra pessoa? Digite '1' para verdadeiro e '2' para falso.");
int aprovacao = Convert.ToInt32(Console.ReadLine());

// Resposta dependendo da aprovação
if (aprovacao == 1){
    Console.WriteLine("Irei me informar mais sobre!");
} else {
    Console.WriteLine("Não tenho tempo a perder com isso.");
}

// Pergunta a nota final
Console.WriteLine("Qual nota voce dá?");
nota = Convert.ToInt32(Console.ReadLine());

// Exibe o resumo das informações coletadas
Console.WriteLine("Então: " + name + " faz parte de " + assunto + 
                  " e tem " + idade + " anos de idade. " + 
                  "A nota dada foi: " + nota + ".");
