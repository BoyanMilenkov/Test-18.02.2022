using System;

namespace Reverse_Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            int bits = int.Parse(Console.ReadLine());
            int[] vector = new int[bits];
            Gen01(0, vector);
        }
        static void Gen01(int index, int[] vector)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = 0; i <= index; i++)
                {
                    vector[index] = i;
                    Gen01 (index + 1, vector); 
                }
            }
        }
    }
}
