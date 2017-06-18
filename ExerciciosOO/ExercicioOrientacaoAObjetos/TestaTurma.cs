using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOrientacaoAObjetos
{
    class TestaTurma
    {
        static void Main(string[] args)
        {
            Turma t1 = new Turma();
            t1.periodo = "Manhã";
            t1.serie = "4ª";
            t1.sigla = "T1";
            t1.tipoEnsino = "Fundamental";

            Turma t2 = new Turma();
            t2.periodo = "Tarde";
            t2.serie = "8ª";
            t2.sigla = "T2";
            t2.tipoEnsino = "Médio";

            System.Console.WriteLine("Dados da primeira turma");
            System.Console.WriteLine("Periodo: " + t1.periodo);
            System.Console.WriteLine("Serie: " + t1.serie);
            System.Console.WriteLine("Sigla: " + t1.sigla);
            System.Console.WriteLine("Ensino: " + t1.tipoEnsino);

            System.Console.WriteLine();

            System.Console.WriteLine("Dados da segunda turma");
            System.Console.WriteLine("Periodo: " + t2.periodo);
            System.Console.WriteLine("Serie: " + t2.serie);
            System.Console.WriteLine("Sigla: " + t2.sigla);
            System.Console.WriteLine("Ensino: " + t2.tipoEnsino);

            System.Console.WriteLine();

        }
    }
}
