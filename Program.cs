using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
           int start = 0;
            int end = 5;
            // loop from start to end including end
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
            // loop from start to end excluding end
            for (int i = start; i < end; i++)
            {
                Console.WriteLine(i);
            }
            //////////////////While///////////////////////
            int j = 1;
            while (j < 6)
            {
                Console.WriteLine(j);
                j = j + 1;
            }
        }
    }
}
