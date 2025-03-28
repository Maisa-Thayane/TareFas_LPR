int soma = 0;

for (int i = 50; i <= 500; i++) {
    if ((i % 2 != 0) && (i % 3 == 0) ) {
        soma += i;
    }
}
Console.WriteLine("A soma de todos os números ímpares múltiplos de 3 entre 50 e 500 é: " + soma);