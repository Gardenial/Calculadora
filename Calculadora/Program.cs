using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            ControlCalculadora control = new ControlCalculadora();
            control.Operacao();
            Console.ReadLine(); //Manter o prompt Aberto
        }//Fim do método Main
    }//Fim da classe Program
}//Fim do projeto calculadora
