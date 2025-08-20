using System.ComponentModel;
using System.Runtime.CompilerServices;

Console.WriteLine("Qual o nome do seu personagem favorito?");
string? name = Console.ReadLine();
Console.WriteLine("Qual o nome do filme/serie/jogo que esse personagem faz parte?");
string? assunto = Console.ReadLine();
Console.WriteLine("Qual a idade dele?");
int idade = Convert.ToInt32(Console.ReadLine());
int vezes;
double finalizar;
float duracao;
int repetiu;
int nota;

Console.WriteLine("É um filme? Digite '1' para verdadeiro e '2' para falso.");
int filme = Convert.ToInt32(Console.ReadLine());
if (filme == 1) {
    Console.WriteLine("Qual o tempo de duração do filme? Em horas.");
    duracao = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Quantas vezes ja assistiu?");
    vezes = Convert.ToInt32(Console.ReadLine());
} else {
    Console.WriteLine("Quanto tempo levou para terminar o jogo?");
    finalizar = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Quantas vezes ja jogou?");
    repetiu = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Voce recomendaria para outra pessoa? Digite '1' para verdadeiro e '2' para falso.");
int aprovacao = Convert.ToInt32(Console.ReadLine());
if (aprovacao == 1){
Console.WriteLine("Irei me informar mais sobre!");
} else {
    Console.WriteLine("Não tenho tempo a perder com isso.");
}
Console.WriteLine("Qual nota voce dá?");
nota = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Então: " + name + " faz parte de " + assunto + " e tem " + idade + "anos de idade." + "A nota dada foi: " + nota + ".");