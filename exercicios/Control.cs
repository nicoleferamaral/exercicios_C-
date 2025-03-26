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
            Console.WriteLine("\n\nEscolha uma das opções abaixo: "+
                 "\n\n0. Para sair" +
                "\n1. Mostrar Números " +
                "\n2. Média de três números"+
                "\n3. Verificador" +
                "\n4. Tabuada" +
                "\n5. Fatorial" +
                "\n6. Potência e raiz" +
                "\n7. Par ou ímpar" +
                "\n8. Ordem crescente" +
                "\n9. Média" +
                "\n10. Contar vogais" +
                "\n11. Palavra invertida" +
                "\n12. Primo" 
                );

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
                    case 3:
                        Console.Write("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.positivo(num));
                        break;

                    case 4:
                        do
                        {
                            Console.Write("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num > 0)
                            {
                                Console.WriteLine(this.exer.tabuada(num));
                               
                            }
                            else
                            {
                                Console.WriteLine("ERRO, informe um número positivo");
                            }
                        } while (num < 0);
                       break;

                    case 5:
                        do
                        {
                            Console.Write("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num > 0)
                            {
                                Console.WriteLine(this.exer.fatorial(num));
                            }
                            else
                            {
                                Console.WriteLine("ERRO, informe um número positivo");
                            }
                        } while (num < 0);
                        break;

                    case 6:
                        do
                        {
                            Console.WriteLine("\n\nEscolha uma das opções abaixo: " +
                                                    "\n\n0. Voltar para o menu" +
                                                     "\n1. Potência" +
                                                   "\n2. Raiz Quadrada ");
                            num = Convert.ToInt32(Console.ReadLine());

                            if (num == 1){
                                do
                                {
                                    Console.Write("Informe um número para base: ");
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Informe um número para o expoente: ");
                                    num2 = Convert.ToInt32(Console.ReadLine());

                                    if ((num1 > 0) && (num2 > 0))
                                    {
                                        Console.WriteLine(this.exer.potencia(num1, num2));
                                  
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERRO, informe um número positivo");
                                    }
                                } while ((num1 < 0) && (num2 < 0));
                              
                            } else if (num == 2)
                            {
                                do
                                {
                                    Console.Write("Informe um número: ");
                                    num1 = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Informe outro número: ");
                                    num2 = Convert.ToInt32(Console.ReadLine());

                                    if ((num1 > 0) && (num2 > 0))
                                    {
                                        Console.WriteLine(this.exer.raiz(num1));
                                        Console.WriteLine(this.exer.raiz(num2));
                                    }
                                    else
                                    {
                                        Console.WriteLine("ERRO, informe um número positivo");
                                    }
                                } while ((num1 < 0) && (num2 < 0));
                            } else
                            {
                                Console.WriteLine(" ======== Voltando ao Menu ==============");
                            }
                                       
                                   
                                        

                                
                        } while (opcao == 0);
                            break;

                    case 7:
                        do
                        {
                            Console.Write("Informe um número: ");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (num > 0)
                            {
                                Console.WriteLine(this.exer.parImpar(num));
                            }
                            else
                            {
                                Console.WriteLine("ERRO, informe um número positivo");
                            }
                        } while (num < 0);
                        break;

                    case 8:
                        do
                        {
                            Console.Write("Informe um número: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Informe outro número: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            if ((num1 > 0) && (num2 > 0))
                            {
                                Console.WriteLine(this.exer.crescente(num1, num2));
                            }
                            else
                            {
                                Console.WriteLine("ERRO, informe um número positivo");
                            }
                        } while ((num1 > 0) && (num2 > 0));
                        break;

           
                    case 10:
                   
                            Console.Write("Informe uma palavra: ");
                            string palavra = Console.ReadLine();
                         
                           Console.WriteLine(this.exer.vogais(palavra));
                         
                               
                            
                        break;
                    case 11:
                        Console.Write("Informe uma palavra: ");
                        palavra = Console.ReadLine();

                        Console.WriteLine(this.exer.inverter(palavra));
                    break;

                    case 12:
                        Console.Write("Verificando se um número é primo\n");
                        while(true)
{
                            Console.WriteLine("Informe um número até 99998(99999 sai)");
                            var numero = Int32.Parse(Console.ReadLine());
                            if (numero == 99999)
                                break;

                            if (numero < 2 || numero > 99998)
                            {
                                Console.WriteLine("Número menor que 2 e maior que 1000 não vale");
                            }
                            else
                            {
                                Console.WriteLine(this.exer.inverter(numero));
                                Console.WriteLine("O número { 0}  { 1}  primo.\n", numero, resultado ? "É" : "NÃO ");
                            }
                        }



                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        break;
                        }
                } while(opcao != 0);


        }
    }//fim da classe
}//fim do projeto
