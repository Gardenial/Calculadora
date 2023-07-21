using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ModelCalculadora
    {
        //Declarando variáveis
        private double num1;
        private double num2;

        //Método Construtor
        public ModelCalculadora() 
        {
        
            GetSetNum1 = 0;
            GetSetNum2 = 0;


        }//Fim do Método Construtor

        //Metodos get e set

        public double GetSetNum1
        { get { return this.num1; } set { this.num1 = value; } }
        //Fim do Get Set Num1

        public double GetSetNum2
        { get { return this.num2; } set { this.num2 = value;} }
        //Fim do Get Set Num2

        
        //Métodos

        public double Somar()
        {
            return GetSetNum1 + GetSetNum2;

        }//Fim do método Somar

        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;

        }//Fim do método Subtrair

        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;

            }
            else
            {
                return GetSetNum1 / GetSetNum2;
            }
            
        }

        public double Multiplicar() 
        {
            
            return GetSetNum1 * GetSetNum2;
        
        }//Fim do Método Multiplicar

        public double Potencia()
        {

            return Math.Pow(GetSetNum1, GetSetNum2);

        }//Fim do Método potência 

        public string Raiz() 
        {
            string msg = "Raiz do primeiro número" + Math.Sqrt(GetSetNum1) + 
                         "\nRaiz do segundo número" + Math.Sqrt(GetSetNum2);

            return msg;

            
        }//Fim do método raiz

        public string TabuadaNum1()
        {

            string resultado = "";

            for(int i = 0; i <= 10; i++) 
            {

                resultado += "\n" + GetSetNum1 + " * " + i + " = " + (GetSetNum1 * 1);

            
            }//Fim do for

            return resultado;
        
        }// Fim do método TabuadaNum1

        public string DecimalParaBinario(int n)
        {
            int resto;
            
            string result = string.Empty;
            while (n > 0)
            {
                resto = n % 2;
                n /= 2;
                result += resto.ToString();
            }// Fim do While

            string invertido = "";


            for (int i = result.Length; i > 0; i--)
            {
                string letra = result.Substring(i - 1, 1);
                invertido += letra;
            }

            return invertido; 
        } //Fim do Método DecimalParaBinario


        public string BinarioParaDecimal(int n)
        {
            //Conversão Binario em Decimal
            int dec = 0;
            int resto, basenum = 1;
            while (n > 0)
            {
                resto = n % 10;
                dec += resto * basenum;
                basenum *= 2;
                n /= 10;
            }//Fim do While
            return dec.ToString();
        }//Fim do Método BinarioParaDecimal

        public string Bhaskara(double num) 
        {
        
            double delta = 0;
            string msg = "";
            double x1 = 0;
            double x2 = 0;

            delta = (Math.Pow(GetSetNum2, 2) - 4 * GetSetNum1 * num);

            if (delta < 0)
            {
                msg = "Impossivel Realizar a Operação, Delta menor que zero." + "Valor de delta:" + delta;
                return msg;


            }//Fim do IF
            else
            {

                

                x1 = (-GetSetNum2 + Math.Sqrt(delta)) / (2 * GetSetNum1);
                x2 = (-GetSetNum2 - Math.Sqrt(delta)) / (2 * GetSetNum1);
                msg = "Valor de x1: " + x1 + "\nValor de x2: " + x2 + "\nValor de delta: " + delta;
                return msg;
            }//Fim do Else

        }// Fim do Método 

        public string DecimalParaHexa()
        {
            int num_decimal = 0;
            string num_hexadecimal;



            Console.WriteLine("Informe um numero em decimal : ");
            num_decimal = int.Parse(Console.ReadLine());



            string an = num_hexadecimal = num_decimal.ToString("X");
            return an;
        }//Fim do Metodo DecimalParaHexa

        public double ConverterHexaDecimal(string hexadecimal)
        {
            double dec = 0;
            string caract = "";
            int num = 0;
            int tamanho = hexadecimal.Length;
            int pote = tamanho;
            for (int i = 0; i < tamanho; i++)
            {
                pote--;
                caract = hexadecimal.Substring(i, 1);
                switch (caract)
                {
                    case "A":
                        num = 10;
                        break;
                    case "B":
                        num = 11;
                        break;
                    case "C":
                        num = 12;
                        break;
                    case "D":
                        num = 13;
                        break;
                    case "E":
                        num = 14;
                        break;
                    case "F":
                        num = 15;
                        break;
                    default:
                        num = Convert.ToInt32(caract);
                        break;
                }//fim do switch
                dec += num * Math.Pow(16, pote);
            }//fim do for
            return dec;
        }//fim do método converter Hexa para Decimal

    }//Fim da classe
}//Fim do projeto
