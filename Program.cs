using System;

namespace Exercicio91
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[50]; 

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}° numero");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = i + 1; j < vet.Length; j++)
                {
                    if (vet[i] == vet[j])
                    {
                        Console.WriteLine($"Numeros repitidos nas posições {i} e {j}- numero repitido {vet[i]}");
                    }
                }
            }
        }
    }
}
