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
                "\n12. Primo" +
                "\n=============  2º ================" +
                "\n13. Soma mais multiplicação" +
                "\n14. Média de três números" +
                "\n15. 15%" +
                "\n16. 5% e 50%" +
                "\n17. Quadrado" +
                "\n18. Velocidade em Km/h" +
                "\n19. IMC" +
                "\n20. Desconto de 9%" +
                "\n21. Desconto de 7%" +
                "\n22. Volume retangular" +
                "\n23. Desconto de 27%" +
                "\n24. Area trapézio" +
                "\n25. Nota final" +
                "\n26. Parcela" +
                "\n27. Consumo de combustível" 
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

                    case 9:
                        int quan = 0;
                        do
                        {
                            int result = 0;
                            Console.Write("Informe uma quantidade: ");
                            quan = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < quan; i++)
                            {
                                Console.Write("Informe o "+ (i+1)+ "º número: ");
                                num = Convert.ToInt32(Console.ReadLine());
                                result = num + result ;
                            }
                            if (quan > 0)
                            {
                                Console.WriteLine(this.exer.mediaTotal(result,quan));
                            }
                            else
                            {
                                Console.WriteLine("ERRO, informe um número positivo");
                            }
                        } 
                        while (quan < 0);
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
                        Console.Write("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(this.exer.VerificaNumeroPrimo(num));

                        break;
                    case 13:
                
                        Console.WriteLine("Informe um número: ");
                        double nume1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        double nume2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.exer.SomarMulti(nume1,nume2));

                        break;
                    case 14:
                        Console.WriteLine("Informe o 1º número: ");
                         double val1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o 2º número: ");
                        double val2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o 2º número: ");
                        double val3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.exer.mediaVal(val1, val2, val3));
                        break;
                    case 15:
                        Console.Write("Informe um valor: ");
                        double nume = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.exer.quinze(nume));

                        break;
                    case 16:
                        Console.Write("Informe um valor: ");
                        nume = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.exer.cincoCinquenta(nume));

                        break;

                    case 17:
                        Console.Write("Informe um valor: ");
                        nume1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Informe outro valor: ");
                        nume2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(this.exer.quadrado(nume1, nume2));
                        break;

                    case 18:
                        do
                        {
                            Console.Write("Informe uma velocidade em m/s: ");
                            nume = Convert.ToDouble(Console.ReadLine());
                            
                            if (nume > 0)
                            {
                                Console.WriteLine(this.exer.km(nume));
                            }
                            else
                            {
                                Console.WriteLine("ERRO, informe um número positivo");
                            }
                        } while (nume < 0);
                        break;
                    case 19:
                        do
                        {
                            Console.Write("Informe sua altura: ");
                            nume1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe seu peso: ");
                            nume2 = Convert.ToDouble(Console.ReadLine());

                            if ((nume1 > 0) && (nume2 > 0))
                            {
                                Console.WriteLine(this.exer.imc(nume1, nume2));
                            }
                            else
                            {
                                Console.WriteLine("ERRO, informe um número positivo");
                            }
                        } while ((nume1 < 0) || (nume2 < 0));
                        break;

                    case 20:
                        Console.Write("Informe um valor: ");
                        nume = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.exer.desconto9(nume));

                        break;

                    case 21:
                        Console.Write("Informe um valor: ");
                        nume = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.exer.desconto7(nume));

                        break;
                    case 22:
                        double nume3 = 0;
                        do
                        {
                            Console.Write("Informe o comprimento da caixa: ");
                            nume1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe a altura: ");
                            nume2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe a largura: ");
                            nume3 = Convert.ToDouble(Console.ReadLine());
                            if ((nume1 > 0) && (nume2 > 0)&& (nume3>0))
                            {
                                Console.WriteLine(this.exer.volume(nume1, nume2,nume3));
                            }
                            else
                            {
                                Console.WriteLine("ERRO, informe um número positivo");
                            }
                        } while ((nume1 < 0) || (nume2 < 0) || (nume3 < 0));
                        break;

                    case 23:
                        Console.Write("Informe um valor: ");
                        nume = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.exer.desconto27(nume));

                        break;
                    case 24:
                        do
                        {
                            Console.Write("Informe a Base maior: ");
                            nume1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe a Base menor: ");
                            nume2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe a altura: ");
                            nume3 = Convert.ToDouble(Console.ReadLine());
                            if ((nume1 > 0) && (nume2 > 0) && (nume3 > 0))
                            {
                                Console.WriteLine(this.exer.trapezio(nume1, nume2, nume3));
                            }
                            else
                            {
                                Console.WriteLine("ERRO, informe um número positivo");
                            }
                        } while ((nume1 < 0) || (nume2 < 0) || (nume3 < 0));
                        break;

                    case 25:
                        Console.WriteLine("Informe Uma nota entre 0 e 10");
                        nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe Uma nota entre 0 e 10");
                        nota2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe Uma nota entre 0 e 10");
                        nota3 = Convert.ToDouble(Console.ReadLine());

                        //executar
                        double mediaPonderada = this.exer.mediaPonderada(nota1, nota2, nota3);

                        if (mediaPonderada == -1)
                        {
                            Console.WriteLine("Uma ou mais notas estão erradas, digite novamente");
                        }
                        else
                        {
                            Console.WriteLine("\n\n A média é: " + mediaPonderada);
                        }
                        break;
                    case 26:
                        do
                        {
                            Console.Write("Informe o valor do produto: ");
                            nume = Convert.ToDouble(Console.ReadLine());
                          
                            if (nume > 0)
                            {
                                Console.WriteLine(this.exer.parcela(nume));
                            }
                            else
                            {
                                Console.WriteLine("ERRO, informe um número positivo");
                            }
                        } while (nume < 0);
                        break;

                    case 27:
                        do
                        {
                            Console.Write("Informe a distância total (KM): ");
                            nume1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Informe a quantidade consumida de combustível (Litros): ");
                            nume2 = Convert.ToDouble(Console.ReadLine());
                  
                            if ((nume1 > 0) && (nume2 > 0))
                            {
                                Console.WriteLine(this.exer.consumo(nume1, nume2));
                            }
                            else
                            {
                                Console.WriteLine("ERRO, informe um número positivo");
                            }
                        } while ((nume1 < 0) || (nume2 < 0));
                        break;



                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        break;
                        }
                } while(opcao != 0);


        }
    }//fim da classe
}//fim do projeto
