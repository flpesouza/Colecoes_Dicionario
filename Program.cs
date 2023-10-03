using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;

namespace Exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int cont = 0;

            Console.WriteLine("Digite a frase: ");
            string frase = Console.ReadLine();

            frase = frase.ToLower();

            string[] fraseArray = frase.Split(' ');

            foreach(string s in fraseArray)
            {
                if (fraseArray.Contains(s))
                {
                    dic[s]++;
                }
                else
                {
                    dic[s] = 1;
                }
            }

            foreach (var kvp in dic)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} ocorrência(s)");
            }

            Console.ReadLine();
        }
    }
}
