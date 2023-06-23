using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace ConsoleApp4
{
    class Program
    {
      
        
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio Tecnico!");
            while (true)
            {
                menu();
            }
        }
       static void menu()
        {
            string menuzin = "Bem vindo ao menu";
            Console.WriteLine(menuzin);
            Console.WriteLine("Digite qual opção voce quer");
            Console.WriteLine("1 PARA = Digitação dos 10 números inteiros no vetor"); // ok
            Console.WriteLine("2 PARA = Impressão do valor do somatório dos números do vetor"); //ok
            Console.WriteLine("3 PARA = Impressão média dos números do vetor"); //ok    
            Console.WriteLine("4 PARA = Substituir todos os números negativos por zero");
            Console.WriteLine("5 PARA = Substituir todos os números repetidos por zero");
            Console.WriteLine("6 PARA = Proponha uma nova função utilizando o vetor.");
            Console.WriteLine("7 PARA = Mostrar todos os números do vetor ");

            int leitura = 0;
            try
            {
                leitura = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Digite um numero válido");
                return;
            }
            switch (leitura)
            {
                case 1:
                    Funcoes.inputnumeros();
                    break;
                case 2:
                     Console.WriteLine(Funcoes.SomaTudo());
                    break;
                case 3:
                    Console.WriteLine(Funcoes.MediaTudo());
                    break;
                case 4:
                    Funcoes.SubstituiZeros();
                    break;
                case 5:
                    Funcoes.SubstituiN_Repitidos();
                    break;
                case 6:
                    Funcoes.Desenho();
                    break;
                case 7:
                    Funcoes.MostraVector();
                    break;
                   
            }
       }      
    }
 }
          