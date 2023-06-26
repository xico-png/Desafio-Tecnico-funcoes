using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

using System.Security.Cryptography;
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
                Console.WriteLine($"Digite o {x + 1}° número");
                string numero = Console.ReadLine();
                numerosint[x] = Convert.ToInt32(numero);

            }

        }
        ///Função 2: Somatorio de todos os valores do vetor numersint[] ///

        public static int SomaTudo()
        {
            foreach (int x in numerosint)
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
        {
            int contador = 0;
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
                for (int contador = 0; contador < numerosint.Length; contador++)
                {
                    if (numerosint[contador] == numerosiguais)
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
            foreach (int x in numerosint)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
        
        public static void Cripotografar()
        {
            int contadorzein = 1;
            string mensagemOrigem = "";
            string chave = ""; 
            byte[] chaveBytes = SHA256.HashData(Encoding.UTF8.GetBytes(chave));
            foreach (int x in numerosint)
            {
                 mensagemOrigem = Convert.ToString(x);
                 chave = "Andery_This_Is_Secret"; 

                byte[] mensagemBytes = Encoding.UTF8.GetBytes(mensagemOrigem);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = chaveBytes;
                    aes.GenerateIV(); // Gera um novo vetor de inicialização (IV) aleatório

                    byte[] iv = aes.IV; // Armazena o IV para uso posterior

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    byte[] textoCriptografado = encryptor.TransformFinalBlock(mensagemBytes, 0, mensagemBytes.Length);

                    // Para transmitir o texto criptografado, você precisa enviar o textoCriptografado e o IV
                    // e depois fazer o processo inverso para descriptografar.
                    string Cripotografado= Convert.ToBase64String(textoCriptografado);
                    string ivcorreta = Convert.ToBase64String(iv);
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                    Console.WriteLine($"{contadorzein++}°Número do vetor criptografado: {Cripotografado}");
                    Console.WriteLine($"IV: {ivcorreta}");
                    Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

                }
            }
            
            
        }
    }
}
