using System;

namespace lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine()); //enter number of elements in array through console

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {

                arr[i] = int.Parse(Console.ReadLine()); //enter elements of array through console
            }
            for (int j = 0; j < arr.Length; j++) //iterate along the length or array
            {
                Console.Write(arr[j] + " " + arr[j] + " "); //display ih such way that elements will repeat
            }
        }
    }
}