Console.WriteLine("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0){
    Console.WriteLine("O número " + num + " é par.");
    Console.WriteLine("O produto de um número par com qualquer outro número sempre resulta em um número par.");
} else {
    Console.WriteLine("O número " + num + " é impar.");
    Console.WriteLine("O quadrado de qualquer número ímpar também é um número ímpar.");
}