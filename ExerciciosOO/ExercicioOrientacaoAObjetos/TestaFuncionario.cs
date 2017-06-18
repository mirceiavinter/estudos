using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOrientacaoAObjetos
{
    class TestaFuncionario
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            func1.nome = "Funcionario 1";
            func1.salario = 1200.50;

            Funcionario func2 = new Funcionario();
            func2.nome = "Funcionario 2";
            func2.salario = 2400.84;

            System.Console.WriteLine("Dados do primeiro funcionario");
            System.Console.WriteLine("Nome: " + func1.nome);
            System.Console.WriteLine("Salario: " + func1.salario);
            
            System.Console.WriteLine();

            System.Console.WriteLine("Dados do segundo funcionario");
            System.Console.WriteLine("Nome: " + func2.nome);
            System.Console.WriteLine("Salario: " + func2.salario);
            
            System.Console.WriteLine();

        }
    }
}
