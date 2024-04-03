using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPOO
{
    public class Calculadora
    {
        //PROPRIEDADES
        private double n1;
        private double n2;
        private double resultado;
        private string operador;
        
        //CONSTRUTOR
        public Calculadora(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }


        //METADOS GET - SET
        //GET ( PARA LER INFORMAÇÃO ) -
        //SET ( PARA INSERIR INFORMAÇÃO ) -

        //--------> GET <--------//
        public double getN1() 
        {
            return this.n1;
        }

        public double getN2()
        {
            return this.n2;
        }

        public double getResultado()
        {
            return this.resultado;
        }

        public string getOperador()
        {
            return this.operador;
        }
        

        //--------> SET <--------//
        public void setN1(double n1)
        {
            this.n1 = n1;
        }

        public void setN2(double n2)
        {
            this.n2 = n2;
        }

        public void setResultado(double resultado)
        {
            this.resultado = resultado;
        }

        public void setOperador(string operador)
        {
            this.operador = operador;
        }


        //METADOS
        public double somar ()
        {
             this.resultado = this.n1 + this.n2;
            return this.resultado;
        }
        public double subtracao()
        {
            this.resultado = this.n1 - this.n2;
            return this.resultado;
        }
        public double multiplicacao()
        {
            this.resultado = this.n1 * this.n2;
            return this.resultado;

        }
        public double divisao()
        {
            this.resultado = this.n1 / this.n2;
            return this.resultado;
        }

        
    }
}
