using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Funcoes
    {       /// Variaveis ///
        private static int soma;
        int resposta;
        private static int[] numerosint = new int[10];
        
        /// Funções ///
        public static void inputnumeros() // Adiciona Valores no vetorexemplor
        {
            
            for (int x = 0; x != 10; x++)
            {
                Console.WriteLine($"Digite o {x+1}° número");
                string numero = Console.ReadLine();
                numerosint[x] = Convert.ToInt32(numero);
                
            }
         
        }
        ///Função 2: Somatorio de todos os valores do vetor numersint[] ///
        
        public static int SomaTudo()
        {
            foreach(int x in numerosint)
            {
                soma = soma + x;
            }
            return soma;
            
        }


        ///Função 3: Imprimir a media de todos os valores///
        public static int MediaTudo()
        {
            return (SomaTudo() / 10);
        }

        ///Função 4: Substituir todos os numeros negativos por 0///
        public static void SubstituiZeros()
        { int contador = 0;
            foreach (int x in numerosint)
            { 
                if (x < 0) { numerosint[contador] = 0; }
                contador++;
            }
        }
        /// Função :5 Substituir todos os numeros que se repete /

        public static void SubstituiN_Repitidos()
        {
            int numerosiguais;
            foreach (int x in numerosint)
            {
                int repete = 0;
                numerosiguais = x;
                for(int contador =0; contador <numerosint.Length; contador++)
                {
                    if(numerosint[contador] == numerosiguais)
                    {
                        repete++;
                    }
                    if (repete == 2)
                    {
                        numerosint[contador] = 0;
                        repete = 0;
                    }
                }

            }
        }
        public static void MostraVector() //Mostra vetores
        {
            foreach(int x in numerosint)
            {
                Console.Write(x+ " ");
            }
            Console.WriteLine();
        }
        
       public static void Desenho()
        {
            if (SomaTudo() > 10)
            {
                Console.WriteLine("        AAAAA      ");
                Console.WriteLine("       AA   AA     ");
                Console.WriteLine("      AA     AA    ");
                Console.WriteLine("     AA       AA   ");
                Console.WriteLine("    AAAAAAAAAAAAA  ");
                Console.WriteLine("   AA           AA ");
                Console.WriteLine("  AA             AA");
                Console.WriteLine(" AA               AA");
                Console.WriteLine("AA                 AA");
                Console.WriteLine();
                Console.WriteLine("AA           AA");
                Console.WriteLine("NN           NN");
                Console.WriteLine("NNN          NN");
                Console.WriteLine("NNNN         NN");
                Console.WriteLine("NN NN        NN");
                Console.WriteLine("NN  NN       NN");
                Console.WriteLine("NN   NN      NN");
                Console.WriteLine("NN    NN     NN");
                Console.WriteLine("NN     NN    NN");
                Console.WriteLine("NN      NN   NN");
                Console.WriteLine("NN       NN  NN");
                Console.WriteLine("NN        NN NN");
                Console.WriteLine("NN         NNNN");
                Console.WriteLine("NN          NNN");
                Console.WriteLine();
                Console.WriteLine("DDDDDDDDDDDD   ");
                Console.WriteLine("DD          DD ");
                Console.WriteLine("DD           DD");
                Console.WriteLine("DD           DD");
                Console.WriteLine("DD           DD");
                Console.WriteLine("DD           DD");
                Console.WriteLine("DD           DD");
                Console.WriteLine("DD           DD");
                Console.WriteLine("DD           DD");
                Console.WriteLine("DD           DD");
                Console.WriteLine("DD          DD ");
                Console.WriteLine("DDDDDDDDDDDD   ");
                Console.WriteLine();
                Console.WriteLine("EEEEEEEEEEE");
                Console.WriteLine("EE         ");
                Console.WriteLine("EE         ");
                Console.WriteLine("EE         ");
                Console.WriteLine("EEEEEEEE   ");
                Console.WriteLine("EE         ");
                Console.WriteLine("EE         ");
                Console.WriteLine("EE         ");
                Console.WriteLine("EE         ");
                Console.WriteLine("EE         ");
                Console.WriteLine("EEEEEEEEEEE");
                Console.WriteLine();
                Console.WriteLine("RRRRRRRRRR   ");
                Console.WriteLine("RR       RR ");
                Console.WriteLine("RR       RR ");
                Console.WriteLine("RR       RR ");
                Console.WriteLine("RRRRRRRRRR   ");
                Console.WriteLine("RR    RR    ");
                Console.WriteLine("RR     RR   ");
                Console.WriteLine("RR      RR  ");
                Console.WriteLine("RR       RR ");
                Console.WriteLine("RR        RR");
                Console.WriteLine();
                Console.WriteLine("YY       YY");
                Console.WriteLine(" YY     YY ");
                Console.WriteLine("  YY   YY  ");
                Console.WriteLine("   YY YY   ");
                Console.WriteLine("    YYY    ");
                Console.WriteLine("    YYY    ");
                Console.WriteLine("    YYY    ");
                Console.WriteLine("    YYY    ");
                Console.WriteLine("    YYY    ");
                Console.WriteLine("    YYY    ");
            }
            Console.WriteLine();
        }
    }
}
