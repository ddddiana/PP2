using System;

namespace task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n, k, p; //integers
            n = int.Parse(Console.ReadLine()); //enter number of elements in array through console

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {

                arr[i] = int.Parse(Console.ReadLine()); //enter array elements through console

            }
            for (int j = 1; j < arr.Length; j++) //iterate through the elements of array
            {
                k = 2;
                p = 1; //as true/false
                while (k < arr[j]) //while arr greater than k, check if arr elements evenly divisible 
                {
                    if (arr[j] % k == 0) 
                    {
                        p = 0;
                        break; //if elements evenly divisible - not prime, it breaks
                    }
                    k++;
                }

                if (p == 1) 
                {
                    Console.Write(arr[j] + " "); //if it is false show the elements which are prime
                }
            }


        }
    }
}