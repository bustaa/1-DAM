using System;

namespace Ejercicio30
{
    class Program
    {
        static void LlenarArray(int[] arr)
        {
            int num;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Introduce un numero: ");
                num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }
        }

        static bool EsPar(int n)
        {
            if (n % 2 == 0) return true;
            return false;
        }


        static void Main(string[] args)
        {
            int[] nums = new int[10];
            LlenarArray(nums);
            int pos = 0;
            foreach (int num in nums)
            {
                pos++;
                if (EsPar(num))
                {
                    Console.WriteLine($"Posición {pos}:\tPar");
                }
                else 
                {
                    Console.WriteLine($"Posición {pos}:\tImpar");
                }
            }
        }
    }
}
