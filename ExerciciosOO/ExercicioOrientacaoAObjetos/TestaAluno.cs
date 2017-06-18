using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOrientacaoAObjetos
{
    class TestaAluno
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.nome = "Aluno 1";
            a1.rg = "111111";
            a1.dataNascimento = "01/01/2013";

            Aluno a2 = new Aluno();
            a2.nome = "Aluno 2";
            a2.rg = "222222";
            a2.dataNascimento = "01/01/2012";

            System.Console.WriteLine("Dados do primeiro aluno");
            System.Console.WriteLine("Nome: " + a1.nome);
            System.Console.WriteLine("RG: " + a1.rg);
            System.Console.WriteLine("Data de Nascimento: " + a1.dataNascimento);

            System.Console.WriteLine();

            System.Console.WriteLine("Dados do segundo aluno");
            System.Console.WriteLine("Nome: " + a2.nome);
            System.Console.WriteLine("RG: " + a2.rg);
            System.Console.WriteLine("Data de Nascimento: " + a2.dataNascimento);

            System.Console.WriteLine();

        }
    }
}
