using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };
            

            int[] arr2 = new int[0];
            for (int i = arr1.Length -1; i >= 0; i--)
            {
                Array.Resize(ref arr2, arr2.Length + 1);
                arr2[arr2.Length - 1] = arr1[i];
               
            }
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }

        }
    }
}
