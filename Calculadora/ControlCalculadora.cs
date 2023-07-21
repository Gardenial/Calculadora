using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ControlCalculadora
    {
        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora;

        public ControlCalculadora() 
        {

            this.calculadora = new ModelCalculadora();
            
        }//Fim do construtor

        public void Coletar()
        {
            Console.WriteLine("Informe um Número: ");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe outro Número: ");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());

        }//Fim do método Coletar

        public int Menu()
        {

            Console.WriteLine("-------------------MENU-------------------" +
                "\n 1.Somar"                      +
                "\n 2.Subtrair"                   +
                "\n 3.Dividir"                    +
                "\n 4.Multiplicar"                +
                "\n 5.Potência"                   +
                "\n 6.Raiz"                       +
                "\n 7.Tabuada"                    +
                "\n 8.Decimal Para Binario"       +
                "\n 9.Binario Para Decimal"       +
                "\n 10.Bhaskara"                  +
                "\n 11.Decimal para Hexadecimal"  +
                "\n 12.Hexadecimal para Decimal"  +
                "\n 0. Sair"                      +
                "\n\n Escolha uma das alternativas acima: ");
                

            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//Fim do Método Menu


        public void Operacao()
        {
            
            int opcao = 0;
            do
            {

                opcao = Menu();
                Console.Clear();


                switch (opcao)
                {

                    case 0:

                        Console.WriteLine("Obrigado");
                        break;
                    case 1:
                        Coletar();
                        Console.WriteLine("Soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("Subtração: " + this.calculadora.Subtrair());
                        break;
                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {

                            Console.WriteLine("Impossivel dividir por 0");

                        }
                        else
                        {

                            Console.WriteLine("Divisão: " + this.calculadora.Dividir());
                        }
                        break;

                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar: " + this.calculadora.Multiplicar());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência: " + this.calculadora.Potencia());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine("Raiz: " + this.calculadora.Raiz());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;
                    case 8:
                        Console.WriteLine("Informe um Número: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.calculadora.DecimalParaBinario(n));
                        break;
                    case 9:
                        Console.WriteLine("Informe um Número");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.calculadora.BinarioParaDecimal(n));
                        break;
                    case 10:
                        Coletar();
                        Console.WriteLine("Informe um terceiro Número");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.Bhaskara(num));
                        break;
                    case 11:
                        Console.WriteLine(this.calculadora.DecimalParaHexa());
                        break; 
                    case 12:
                        Console.WriteLine("Informe um valor em Hexadecimal: ");
                        Console.WriteLine(this.calculadora.ConverterHexaDecimal(Console.ReadLine()));
                        break;
                    default:
                        Console.WriteLine("─►Opção escolhida não é valida");
                        break;


                } //Fim do Switch
            } while (opcao != 0);// Fim do Do...While

        }//Fim do Método Operacao

    }//Fim da classe ControlCalculadora

}//Fim do projeto
