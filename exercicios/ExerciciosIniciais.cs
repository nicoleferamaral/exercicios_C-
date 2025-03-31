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

        public string SomarMulti(double num1, double num2)
        {
            double result = (num1 + num2);
            return "O resultado final da soma entre " + num1+ " + " + num2 + " e da multiplicação " + result + " * " + num1 + " é igual a: " + (result * num1);
        }


        public string mediaVal(double val1, double val2, double val3)
        {
            double med = 0.0;
                med = (val1 + val2 + val3) / 3;
                return "A média é: "+med;
          
        }

        public string quinze(double num)
        {
            return "15% de " + num + " é igual a: " + (num * 0.15);
        }

        public string cincoCinquenta(double num)
        {
            return "5% de " + num + " é igual a: " + (num * 0.05)+ "\n50% de " + num + " é igual a: " + (num * 0.50);
        }

        public string quadrado(double num1, double num2)
        {
            double result1 = num1 * num1;
            double result2 = num2 * num2;
            return num1 + "² = " + result1 + "\n"+ num2 + "² = " + result2 + "\nA soma dos resultados é: "+ (result1+result2);
        }

        public string km(double num)
        {
            return num + "m/s = " + (num * 3.6) + "km/h";
        }

        public string imc(double alt, double peso)
        {
            double altura = alt * alt;
            return "Seu IMC é = " + (peso/altura);
        }

        public string desconto9(double num)
        {
            double result = num * 0.09;
            return num + " com um desconto de 9% = "+ (num-result); 
        }

        public string desconto7(double num)
        {
            double result = num * 0.07;
            return "7% de "+ num+ " = "+result + "\nCom o desconto = " + (num - result);
        }

        public string volume(double comp, double alt, double larg)
        {
            return "O volume dessa caixa retangular é = "+(comp*alt*larg);
        }

        public string desconto27(double num)
        {
            double result = num * 0.27;
            return "27% de " + num + " = " + result + "\nCom o desconto = " + (num - result);   
        }

        public string trapezio(double baseMaior, double baseMenor, double altura)
        {
            return "A área do trapézio é = "+(((baseMenor+baseMaior)*altura)/2);
        }

        public double mediaPonderada(double nota1, double nota2, double nota3)
        {
            double med = 0; // instanciando
            if((nota1>= 0 && nota1 <= 10) && (nota2>=0 && nota2 <= 10) && (nota3>=0 && nota3 <= 10))
            {
                double resul1 = nota1 * 2;
                double resul2 = nota2 * 3;
                double resul3 = nota3 * 5;
                med = (resul1 + resul2 + resul3) / 3;
                return med;
            }
            return -1;
        }

        public string parcela(double num)
        {
            double result = num + (num * 0.16);
            return "O valor total da compra: " + result + "\nO valor de cada parcela em 10x: " + (result / 10);
        }

        public string consumo(double km, double litros)
        {
            return "O consumo médio de combustível foi: " + (km / litros);
        }

    }// fim da classe
} // Fim do projeto
