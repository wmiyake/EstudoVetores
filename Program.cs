﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstudoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] meuVetor = new int[10];
            for (int i = 0; i <=9; i++)
            {
                meuVetor[i] = i + 1;
            }
            /*for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Posição {0} = {1}", i, meuVetor[i]);
            }*/

            foreach(int numero in meuVetor)
            {
                Console.WriteLine("{0}", numero);
            }
            Console.WriteLine("O tamanho do vetor é {0}", meuVetor.Length);
            Console.ReadKey();
        }
    }
}
