using System;

namespace LearningArrays
{
    class LearningArrays
    {
        static void Main(string[] args)
        {
            // Task1:
            // Step 1: Array Declaration
            string[] sarasas;

            // Step 2:Array Initialization
            sarasas = new string[5] { "Antanas", "Petras", "Jonas", "Aloyzas", "Martynas" };

            //Step 3: Loop "for"
            Console.Write("For loop: ");
            for (int j = 0; j < sarasas.Length; j++) Console.Write(" " + sarasas[j]);

            {
                Console.WriteLine();
            }

            //Task2:
            //Step 1: Array Declaration

            int[] skaiciai;

            // Step 2:Array Initialization

            skaiciai = new int[21] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Array.Reverse(skaiciai);

            //Step 3: Loop "for" backwards
            Console.Write("Skaiciai loop: ");
            for (int i = 0; i < skaiciai.Length; i++) Console.Write(" " + skaiciai[i]);

            {
                //Console.WriteLine(skaiciai[i]);
            }
        }
    }
}
