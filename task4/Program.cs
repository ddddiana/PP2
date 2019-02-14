using System;

class Program
{
    static void Main(string[] args)
    {
        int n, i, j, k;
        Console.Write("enter the level:");
        n = int.Parse(Console.ReadLine()); //enter the number of the level through console
        for (i = 1; i <= n; i++)
        {
            for (j = 1; j <= n - 1; j++) //iterate through the end of an array in order to geet triangle form
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++) //iterate through the first elements of an array
            {
                Console.Write("[*]"); //print * with space as it was iterated through arrays 
                Console.Write(" ");
            }
            Console.WriteLine();

        }
    }
}
