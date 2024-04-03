using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NadadorFuncao1
{
    internal class Program
    {
        static string categoria(int idade)
        {
            if (idade >= 5 && idade <= 7)
                return "Sua Categorioa é Infantil A";
            else if (idade >= 8 && idade <=10)
                return "Sua Categorioa é Infantil B";
            else if (idade >= 11 && idade <= 13)
                return "Sua Categorioa é Juvenil A";
            else if (idade >= 14 && idade <= 17)
                return "Sua Categorioa é Juvenil B";
            else
                return "Sua Categoria é Adulto";




        }
        static void Main(string[] args)
        {
            Console.WriteLine("digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(categoria(idade));
        }

    }
}
