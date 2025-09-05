namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            double SalarioB, Imposto;
            Console.Write("Digite o nome do funcionário: ");
            Nome = Console.ReadLine();
            Console.Write("Digite o salário bruto do funcionário: ");
            SalarioB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o imposto do funcionário: ");
            Imposto = Convert.ToDouble(Console.ReadLine());

            Funcionario funcionario = new Funcionario(Nome,SalarioB, Imposto);
            Console.WriteLine(funcionario);

        }
    }
}
