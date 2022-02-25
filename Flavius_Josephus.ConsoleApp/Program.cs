using System;

namespace Flavius_Josephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o número de homens: ");
            int qntHomens = int.Parse( Console.ReadLine());

            int[] homens = new int[qntHomens+1];

            Console.Write("Digite o tamanho do salto entre os homens: ");
            int tamanhoSalto = int.Parse(Console.ReadLine());

            for (int i=1; i<=qntHomens; i++)
            {
                homens[i] = i;
            }

            int j = 1, x = 0, y = 0;

            while (x != qntHomens-1)
            {
                if (homens[j] != 0)
                {
                    y++;

                    if (y == tamanhoSalto)
                    {
                        homens[j] = 0;
                        x++;
                        y = 0;
                    }
                }

                j++;

                if (j > qntHomens)
                {
                    j = 1;
                }
            }

            for(int i=1; i <= qntHomens; i++)
            {
                if (homens[i] != 0)
                {
                    Console.WriteLine(homens[i]+ " sobreviveu!");
                    break;
                }
            }
        }
    }
}
