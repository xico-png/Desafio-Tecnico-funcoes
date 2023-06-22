using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Funcoes
    {       /// Variaveis ///
        private static int soma;
        private static int[] numerosint = new int[10];
        private static bool blockeditioninvec = false;
        /// Funções ///
        public static int inputnumeros() // Adiciona Valores no vetorexemplor
        {
            foreach (int x in numerosint)
            {
                if (x > 0) blockeditioninvec = true;
            }
            if (blockeditioninvec == true) { return 1; }
            for (int x = 0; x != 10; x++)
            {
                Console.WriteLine($"Digite o {x+1}° número");
                string numero = Console.ReadLine();
                numerosint[x] = Convert.ToInt32(numero);
                
            }
          return 0;
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
    }
}
