namespace Atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Altura, Largura;
            Console.Write("Digite a altura do retângulo: ");
            Altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a largura do retângulo: ");
            Largura = Convert.ToDouble(Console.ReadLine());

            calcArea area = new calcArea(Altura, Largura);
            calcPerimetro perimetro = new calcPerimetro(Altura, Largura);
            Console.WriteLine("A área do retângulo é: " + area.Area);
            Console.WriteLine("O perímetro do retângulo é: " + perimetro.Perimetro);

        }
    }
}
