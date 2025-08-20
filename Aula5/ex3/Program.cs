// Variável que vai armazenar a soma dos números desejados
int soma = 0;

// Loop que percorre todos os números de 50 até 500 (inclusive)
for (int i = 50; i <= 500; i++) {

    // Verifica se o número é ímpar (i % 2 != 0) 
    // e múltiplo de 3 (i % 3 == 0) ao mesmo tempo
    if ((i % 2 != 0) && (i % 3 == 0) ) {
        soma += i; // Adiciona o número à soma
    }
}

// Exibe o resultado final
Console.WriteLine("A soma de todos os números ímpares múltiplos de 3 entre 50 e 500 é: " + soma);
