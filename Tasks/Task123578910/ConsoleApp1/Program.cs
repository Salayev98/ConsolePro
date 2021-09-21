using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            //int Num = 15;
            //int Pow = 1;
            //int Result = 1;
            //while (Pow < 4)
            //{
            //    Pow++;
            //    Result *= Num;

            //}
            //Console.WriteLine(Result);
            #endregion
            #region Task2
            //int[] arr = { 1, 8, 3, 10, 5 };
            //int EvenNum = 0;
            //int OddNum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] %2 == 0)
            //    {
            //        EvenNum += arr[i];
            //    }
            //    else
            //    {
            //        OddNum += arr[i];
            //    }
            //}
            //Console.WriteLine(EvenNum-OddNum);
            #endregion
            #region Task3
            //int[] arr = { 10, 101, 10, 202, 10 };

            //int Even3 = 0;
            //int EvenOther = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if ((arr[i] - arr[i] % 10) / 10 > 1 )
            //    {
            //        Even3 += arr[i];

            //    }
            //    else
            //    {
            //        EvenOther += arr[i];
            //    }
            //}
            //Console.WriteLine(Even3 - EvenOther);
            #endregion
            #region Task5
            //int[] arr = { 1, 2, 3, 4, 5 ,34857};
            //int[] arr2 = { 3, 5, 7, 8, 2 };
            //bool check = true;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr2.Length; j++)
            //    {
            //        if (arr[i] == arr2[j])
            //        {
            //            check = false;
            //            break;
            //        }
            //    }
            //    if (check)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //    check = true;

            //}


            #endregion
            #region Task7
            //int[] Nums = { 1, 2, 3, 4, 5 };
            //Reverse(ref Nums);
            #endregion
            #region Task8
            //string Words = "Salam Millet Necesiz";
            //Count(Words);
            #endregion
            #region Task9
            //string Sentence = "Salam 11 ci Sinifler";
            //Console.WriteLine(Char(Sentence)); 

            #endregion
            #region Task10
            int[] Arr = { 1, 2, 3, 4 };
            int a = 5;
            Include(ref Arr, a);
            foreach (var item in Arr)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
        static  void Reverse(ref int[] nums)
        
        {
            int[] EvenNums = new int[0];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Array.Resize(ref EvenNums, EvenNums.Length + 1);
                    EvenNums[EvenNums.Length - 1] = nums[i];
                }
            }
            foreach (var item in EvenNums)
            {
                Console.WriteLine(item);
            }
        }
        static void Count(string words)
        {
            string[] arr = new string[0];
            arr = words.Split(' ');
            Console.WriteLine(arr.Length);
        }
        static bool Char(string sentence)
        {
            
            bool isDigit = false;
            bool isUpper = false;
            bool isLower = false;
            foreach (char item in sentence)
            {
                if (char.IsDigit(item))
                {
                    isDigit = true;
                }
                else if (char.IsUpper(item))
                {
                    isUpper = true;
                }
                else if (char.IsLower(item))
                {
                    isLower = true;
                }
                
            }
            if (isLower&&isDigit&&isUpper)
            {
                return true;
            }
            return false;
        }
        static int[] Include(ref int[] arr, int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
            return arr;
        }

        
    }
}
