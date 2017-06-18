using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaAgencia
    {
        static void Main(string[] args)
        {
            Agencia a1 = new Agencia();
            a1.numero = 1234;

            Agencia a2 = new Agencia();
            a2.numero = 5678;

            System.Console.WriteLine("Dados da primeira agência");
            System.Console.WriteLine("Numero: " + a1.numero);

            System.Console.WriteLine();

            System.Console.WriteLine("-----------------------------------------------");

            System.Console.WriteLine();

            System.Console.WriteLine("Dados da segunda agência");
            System.Console.WriteLine("Numero: " + a2.numero);

        }
    }
}
