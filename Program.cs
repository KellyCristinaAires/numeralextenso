using System;
using Humanizer;

namespace  testeResp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string texto;

            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine ());

            texto = numero.ToWords();
            Console.Write("Seu número em texto é: ");
            Console.WriteLine(texto);
        }
    }
}
