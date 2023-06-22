using System;
using System.Collections.Generic;
namespace ConsoleApp4
{
    class Program
    {
      static List<int> listadenumeros = new List<int> { };

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
            Console.WriteLine("1 PARA =Digitação dos 10 números inteiros no vetor");
            Console.WriteLine("2 PARA =Impressão do valor do somatório dos números do vetor");
            Console.WriteLine("3 PARA =Impressão média dos números do vetor");
            Console.WriteLine("4 PARA =Substituir todos os números negativos por zero");
            Console.WriteLine("5 PARA =Substituir todos os números repetidos por zero");
            Console.WriteLine("6 PARA =Proponha uma nova função utilizando o vetor.");
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
                    inputnumeros();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }
       }
    
              static void inputnumeros()
              {
                Console.WriteLine("Digite 10 numeros separados por espaço, quando quiser deixer vazio digite use: {'vazio, espaco, numerodesejado'} ");
                string numerosss = Console.ReadLine();
                string[] numeroString = numerosss.Split(' ');
                for (int x = 0; x < 11; x++)
                {
                    string nx = numeroString[x];
                    int numerosqueseraoinseridosnovetor = Convert.ToInt32(nx);
                    listadenumeros.Add(numerosqueseraoinseridosnovetor);

                }
                vetordosnumeros(listadenumeros.IndexOf(0), listadenumeros.IndexOf(1), listadenumeros.IndexOf(2), listadenumeros.IndexOf(3), listadenumeros.IndexOf(4), listadenumeros.IndexOf(5), listadenumeros.IndexOf(6), listadenumeros.IndexOf(7), listadenumeros.IndexOf(8), listadenumeros.IndexOf(9));
              }
           static int[] vetordosnumeros(int x1,int x2, int x3, int x4, int x5, int x6, int x7, int x8, int x9, int x10)
            {
                int[] deznumeros = new int[10] { x1,x2,x3,x4,x5,x6,x7,x8,x9,x10};
                return deznumeros;
            }
    }
}

