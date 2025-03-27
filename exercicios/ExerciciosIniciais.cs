using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exercicios
{
    internal class ExerciciosIniciais
    {
        //Area de declaração de variaveis
        private int num1;
        private int num2;

        public ExerciciosIniciais()
        {

        }// fim do construtor


        public ExerciciosIniciais(int num1, int num2) 
        {
            this.num1 = num1;
            this.num2 = num2;

         
        }//Fim do construtor

        //Métodos modificadores, get e set

        public int getNum1() { return this.num1; }
        public int getNum2() { return this.num2; }

        public void setNum1(int num1) { this.num1 = num1; }
        public void setNum2(int num2) { this.num2 = num2; }

        public string imprimir()
        {
            return "\nPrimeiro número: "+ getNum1() + "\nSegundo número: "+ getNum2();
        }// fim do imprimir

        public double media(double nota1, double nota2, double nota3)
        {
            double med = 0; // instanciando
            if((nota1>= 0 && nota1 <= 10) && (nota2>=0 && nota2 <= 10) && (nota3>=0 && nota3 <= 10))
            {
                med = (nota1 + nota2 + nota3) / 3;
                return med;
            }
            return -1;
        }

        public string positivo(int num)
        {
            if (num > 0)
            {
                return "O número " + num + " é POSITIVO";
            } else if(num < 0)
                {
                return "O número " + num + " é NEGATIVO";
                } else
            {
                return "O número é ZERO";
            }
        }

        public string tabuada(int nume)
        {
            string resultado = "";
            for (int i = 0; i < 11; i++) {

                resultado += (i + " * " + nume + " = " + (nume * i) + "\n");
            }
            return resultado;
        }

        public string fatorial(int num)
        {
            int resul = num ;
            for (int i = (num - 1); i >= 1; i--)
            {
                resul = resul * i;
            }
            return "O fatorial de " + num + " é: " + resul;
        }

        public string potencia(int num1, int num2)
        {
            string resultado = "";
            for (int i = 0; i <= num2; i++) {
                resultado = "A potência de " + num1 + "^"+num2 + " é de " + (long)Math.Pow(num1, num2);
            }
            return resultado;
        }

        public string raiz (int num)
        {
            return "A raiz de " + num + " é de " + (Math.Sqrt(num));
        }

        public string parImpar(int num)
        {
            if(num % 2 == 0 )
            {
                return "O número é Par";
            }
            else
            {
                return "O número é ìmpar";
            }
        }

        public string crescente(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num2 + " e " +num1;
            } else
            {
                return num1 + " e " + num2;
            }
        }

        public string mediaTotal(int result, int quan)
        {
            return "A média de todos os números é " + (result / quan);
        }

        public string vogais(string palavra)
        {
            int tamanho = palavra.Length;
            int contador = 0;
            for(int i=0;i<tamanho;i++)
            {
                if ((palavra.Substring(i, 1) == "a") ||
                    (palavra.Substring(i, 1) == "A") ||
                    (palavra.Substring(i, 1) == "e") ||
                    (palavra.Substring(i, 1) == "E") ||
                    (palavra.Substring(i, 1) == "i") ||
                    (palavra.Substring(i, 1) == "I") ||
                    (palavra.Substring(i, 1) == "o") ||
                    (palavra.Substring(i, 1) == "O") ||
                    (palavra.Substring(i, 1) == "u") ||
                    (palavra.Substring(i, 1) == "U"))
                {
                    contador ++;
                }
            }
            return "A palavra " + palavra + " tem " + contador + " vogais";
        }

        public string inverter(string palavra)
        {
            string textoInvertido = new string(palavra.Reverse().ToArray());

            return textoInvertido;

        }

        public string VerificaNumeroPrimo(int num)
        {
            int cont = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    cont = cont + 1;
                }
            }

            if ((cont > 2) || (num == 4))
                return "O número " + num + " NÃO É primo";
            else
                 return "O número " + num + " É primo";
        }


    }// fim da classe
} // Fim do projeto
