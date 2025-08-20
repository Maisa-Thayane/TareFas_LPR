// Pede para o usuário digitar um número inteiro
Console.WriteLine("Digite um número inteiro: ");

// Lê a entrada do usuário (texto), converte para inteiro e armazena na variável 'num'
int num = Convert.ToInt32(Console.ReadLine());

// Verifica se o número é par usando o operador módulo (%)
// Se o resto da divisão por 2 for 0, o número é par
if (num % 2 == 0){
    Console.WriteLine("O número " + num + " é par.");

    // Explicação adicional sobre números pares
    Console.WriteLine("O produto de um número par com qualquer outro número sempre resulta em um número par.");
} 
// Caso contrário, o número é ímpar
else {
    Console.WriteLine("O número " + num + " é impar.");

    // Explicação adicional sobre números ímpares
    Console.WriteLine("O quadrado de qualquer número ímpar também é um número ímpar.");
}
