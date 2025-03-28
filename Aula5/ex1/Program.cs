Console.WriteLine("Digite a quantidade de elementos a serem contabilizados: ");
int quant = Convert.ToInt32(Console.ReadLine());
int[] elementos = new int[quant];
Console.WriteLine("Liste os elementos da media: "); 
int acumulador = 0;
int contagem = 0;
int i = 0; 

while (i < quant) 
{
    Console.Write($"Elemento {i + 1}: ");
    elementos[i] = Convert.ToInt32(Console.ReadLine()); 

    if (elementos[i] % 2 == 0) {
acumulador += elementos[i]; 
contagem++; 
  }
    i++; 
}
if (contagem > 0) 
        {
            double media = (double)acumulador / contagem;
            Console.WriteLine($"A média dos números pares é: {media}");
        }
        else
        {
            Console.WriteLine("Não há números pares para calcular a média.");
        }