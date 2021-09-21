using System;
using System.Collections.Generic;
using System.Text;

namespace Task19
{
    static class  ExtentionMethods
    {
        public static bool IsOdd(this int a)
        {
            bool check = true;
            if (check)
            {
                if (a % 2 == 0)
                {
                    check = false;
                }
            }
            return check;
        }
        public static bool IsEven(this int b)
        {
            bool check = true;
            if (check)
            {
                if (b % 2 != 0)
                {
                    check = false;
                }

            }
            return check;
        }
        public static bool IsContainsDigit( this string word)
        {
            
            bool isDigit = false;
            
                foreach (char item in word)
                {
                    if (char.IsDigit(item))
                    {
                        isDigit = true;
                        
                    }
                }
            return isDigit;
            
        }
        public static int[] GetValueIndexes(this char a)
        {
            int[] arr = new int[0];

            string word = "aSalamMillet";
            foreach (char item in word)
            {
                if (item == a)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = word.IndexOf(item);
                }

            }
            return arr;

        }
        //public static bool GetValueIndexes()
        //{

        //}

    }
}
