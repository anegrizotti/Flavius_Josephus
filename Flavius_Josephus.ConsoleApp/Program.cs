using System;

namespace Flavius_Josephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de homens: ");
            int qntHomens = int.Parse(Console.ReadLine());

            Console.Write("Digite o tamanho do salto: ");
            int tamSalto = int.Parse(Console.ReadLine());

            int[] qntHomensArray = new int[qntHomens];
            int index = 1;

            for (int i = 0; i < qntHomensArray.Length; i++)
            {
                qntHomensArray[i] = index;
                index++;
            }
            
            int ultimoHomem = 0;

            
            for (int i = 0;i < qntHomensArray.Length ;i=i+tamSalto)
            {
                qntHomensArray[i] = -1;
            }



            Console.WriteLine(ultimoHomem);
        }
    }
}
