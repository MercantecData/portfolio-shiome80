using System;

namespace _2019_11_04_GitAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            makeArray(4);
        }

        static int[] makeArray (int indexes)
        {
            int arraySize = indexes + 1;
            int[] a = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }
            return a;
        }
    }
}
