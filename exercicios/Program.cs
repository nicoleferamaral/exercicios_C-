using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Digite seu nome: "); //Escrever e pular linha
            // Console.Write("");//Escrever na mesma linha
            //string nome =  Console.ReadLine(); //Ler

            // Console.WriteLine("\n\n Bem-Vindo " + nome);  //  \n pula linha  + concatena
            // Console.ReadLine();


            // coletei os dados

            //Console.WriteLine("Informe um número: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Informe outro número: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //utilizando


            // ExerciciosIniciais exer = new ExerciciosIniciais(num1, num2);

            //Console.WriteLine(exer.imprimir());

           



            Control controle = new Control();
            controle.menu();
           
            Console.ReadLine(); //Manter o prompt aberto

        } // fim da main
    } // fim da classe
}// Fim do namespace
