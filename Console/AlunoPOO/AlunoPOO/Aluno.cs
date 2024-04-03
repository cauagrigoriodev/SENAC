using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoPOO
{
    public class Aluno
    {
        public string nome;
        public int id;
       // public DateTime dataNasc = new DateTime();
        public string turma;
        public string cpf;
        public double nota1;
        public double nota2;
        public double nota3;
       
        //CONTRUTOR
        public Aluno(int id, string nome, string cpf)
        {
            setId(id);
            setNome(nome);
            setCpf(cpf);
        }

        public Aluno()
        {
        }



        //METADOS GET - SET
        //--------->  SET  <---------\\

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public void setTurma(string turma)
        {
            this.turma = turma;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setNota1(double nota1)
        {
            this.nota1 = nota1;
        }

        public void setNota2(double nota2)
        {
            this.nota2 = nota2;
        }

        public void setNota3(double nota3)
        {
            this.nota3 = nota3;
        }



        //--------->  GET  <---------\\

        public string getNome()
        {
            return this.nome;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public int getId()
        {
            return this.id;
        }

        public double getNota1()
        {
            return this.nota1;
        }

        public double getNota2()
        {
            return this.nota2;
        }
        public double getNota3()
        {
            return this.nota3;
        }

        public void digitarNota1()
        {
            double nota1;
            do
            {
                Console.WriteLine("DIGITE SUA 1ª NOTA: ");
                nota1= Convert.ToDouble(Console.ReadLine());
            } while (nota1 > 0 || nota1 < 10);
            setNota1(nota1);

            double nota2;
            do
            {
                Console.WriteLine("DIGITE SUA 2ª NOTA: ");
                nota2 = Convert.ToDouble(Console.ReadLine());
            } while (nota2 > 0 || nota2 < 10);
            setNota2(nota2);

            double nota3;
            do
            {
                Console.WriteLine("DIGITE SUA 3ª NOTA: ");
                nota3 = Convert.ToDouble(Console.ReadLine());
            } while (nota3 > 0 || nota3 < 10);
            setNota3(nota3);

        }



        //METODOS 
        public double media(double n1, double n2, double n3)
        {
            this.nota1 = n1;
            this.nota1 = n2;
            this.nota1 = n3;
            return (nota1 + nota2 + nota3 / 3); 
        }
        
       
        
    }
}
