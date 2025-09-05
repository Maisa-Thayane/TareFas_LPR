using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Funcionario
    {
        public double salarioL;
        public Funcionario(string nome, double salarioB, double imposto)
        {
            salarioL = salarioB - imposto;
            Console.WriteLine("Nome do funcionário: " + nome);
            Console.WriteLine("Salário líquido do funcionário: " + salarioL);

        }

    }
}
