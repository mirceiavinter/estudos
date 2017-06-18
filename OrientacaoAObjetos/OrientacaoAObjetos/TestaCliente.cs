using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos
{
    class TestaCliente
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente();
            c1.nome = "Rafael Cosentino";
            c1.codigo = 1;

            Cliente c2 = new Cliente();
            c2.nome = "Jonas Hirata";
            c2.codigo = 2;

            System.Console.WriteLine("Dados do Primeiro Cliente");
            System.Console.WriteLine("Nome: " + c1.nome);
            System.Console.WriteLine("Código: " + c1.codigo);

            System.Console.WriteLine(" ----------------------------------------");

            System.Console.WriteLine("Dados do Segundo Cliente");
            System.Console.WriteLine("Nome: " + c2.nome);
            System.Console.WriteLine("Código: " + c2.codigo);
            
        }
    }
}
