using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR UM OBEJTO
            Aluno A1 = new Aluno();

            //ATRIBUIÇÕES DO ALUNO
            Console.WriteLine("DIGITE SEU NOME: ");
            A1.setNome((Console.ReadLine()));
            //Console.WriteLine("DIGITE A SUA DATA DE NASCIMENTO: ");
            //A1.dataNasc = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("DIGITE SUA TURMA: ");
            A1.setTurma((Console.ReadLine()));
            Console.WriteLine("DIGITE Nº DA SUA MATRICULA: ");
            A1.setId((Convert.ToInt32(Console.ReadLine())));
           

            /* INSERINDO NOTAS 
            Console.WriteLine("DIGITE SUA NOTA 1: ");
            A1.setNota1((Convert.ToDouble(Console.ReadLine())));
            Console.WriteLine("DIGITE SUA NOTA 2: ");
            A1.setNota2((Convert.ToDouble(Console.ReadLine())));
            Console.WriteLine("DIGITE SUA NOTA 3: ");
            A1.setNota3((Convert.ToDouble(Console.ReadLine())));
            */

            Console.WriteLine("SUA MEDIA É: " + (A1.media(A1.nota1, A1.nota2, A1.nota3)));

        }
    }
}
