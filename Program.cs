using System;

namespace SortearOrdenar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random numero = new Random();
            int[] vetor = new int[20];
            int aux,valor,i,j;



            for (i = 0; i < vetor.Length; i++)
            {                
                valor = numero.Next(1, 20);

                Console.WriteLine(valor);

                vetor[i] = valor;   
                
                for(j = i; j>0; j--)
                {
                    if(vetor[j] < vetor[j - 1])
                    {
                        aux = vetor[j - 1];
                        vetor[j - 1] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }
            Console.WriteLine("========");
            Console.WriteLine("Vetor");

            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

        }
    }
}
