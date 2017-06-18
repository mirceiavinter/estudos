using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaValoresPadrao
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            System.Console.WriteLine("Valores Padrões");
            System.Console.WriteLine("Número: " + c.numero);
            System.Console.WriteLine("Saldo: " + c.saldo);
            System.Console.WriteLine("Limite: " + c.limite);

        }
    }
}
