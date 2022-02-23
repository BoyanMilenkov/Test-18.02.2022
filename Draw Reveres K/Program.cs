using System;

namespace Draw_Reveres_K
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int a;
            Draw(v, a = 0);
        }
        private static void Draw(int v, int a)
        {
            if (v <= 0)
            {
                return;
            }
            Console.Write(new string(' ', a));
            Console.WriteLine(new string('#', v));
            Draw(v - 1, a + 1);
            Console.Write(new string(' ', a));
            Console.WriteLine(new string('*', v));
            
        }
    }
}
