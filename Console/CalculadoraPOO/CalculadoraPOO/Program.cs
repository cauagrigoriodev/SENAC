using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
    internal class Program
    {
       
       
        static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora(10, 5);
            Console.WriteLine("DIGITE UM NUMERO");
             c1.setN1( Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("DIGITE OUTRO NUMERO");
             c1.setN2( Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite qual operação que deseja:\n 1.SOMAR\n 2.SUBTRAIR\n 3.MULTIPLICAR\n 4.DIVIDIR ");
             c1.setOperador(Console.ReadLine());
            bool continuar;
            do
            {
                switch (c1.getOperador())
                {


                    case "1":
                        Console.WriteLine(" Resultado da Soma: " + (c1.somar()));
                        break;

                    case "2":
                        Console.WriteLine(" Resultado da Subtração: " + (c1.subtracao()));
                        break;

                    case "3":
                        Console.WriteLine(" Resultado da Multiplicação: " + (c1.multiplicacao()));
                        break;

                    case "4":
                        Console.WriteLine(" Resultado da Divisão: " + (c1.divisao()));
                        break;

                    default:
                        Console.WriteLine("Operação invalida");
                        break;
                }


                Console.WriteLine("Deseja continuar? (S/N)");
                string resposta = Console.ReadLine();
                continuar = resposta.ToUpper() == "S";
            } while (continuar);


            }
        }
    }
