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
        { get { return this.num1; } set { this.num1 = value;} }
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
                result = resto.ToString() + result;
            }

            return result.ToString();
        }


        public string BinarioParaDecimal(int n)
        {
            //Conversão Binario em Decimal
            int bin, dec = 0, resto, basenum = 1;
            bin = n;
            while (n > 0)
            {
                resto = n % 10;
                dec = dec + resto * basenum;
                basenum = basenum * 2;
                n = n / 10;
            }
            return dec.ToString();
        }

      
    }//Fim da classe
}//Fim do projeto
