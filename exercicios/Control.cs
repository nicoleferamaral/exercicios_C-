using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class Control
    {
        ExerciciosIniciais exer;

        public Control() 
        { 
            this.exer = new ExerciciosIniciais();
        } // fim do construtor

        public void Mostrarmenu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: "+
                 "\n0. Para sair" +
                "\n1. Mostrar Números " +
                "\n2. Média de três números");

        }// fim do metodo

        public void menu() 
        {
            int opcao = 0;
            do { 
                Mostrarmenu(); //Mostrar as opções para o usuário
                opcao = Convert.ToInt32(Console.ReadLine());

                //escolha

                switch(opcao)
                {
                    case 0:
                        Console.WriteLine("\n\n ==================  Obrigado ======================");
                        break;

                    case 1:
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        ExerciciosIniciais exer = new ExerciciosIniciais(num1,num2);
                        Console.WriteLine(exer.imprimir());
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Informe Uma nota entre 0 e 10");
                        double nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe Uma nota entre 0 e 10");
                        double nota2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe Uma nota entre 0 e 10");
                        double nota3 = Convert.ToDouble(Console.ReadLine());

                        //executar
                        double media =  this.exer.media(nota1,nota2, nota3);

                        if(media == -1)
                        {
                            Console.WriteLine("Uma ou mais notas estão erradas, digite novamente");
                        } else
                        {
                            Console.WriteLine("\n\n A média é: " + media);
                        }
                        break;






                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        break;
                }
            } while(opcao != 0);


        }
    }//fim da classe
}//fim do projeto
