using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        int sum = A ^ B; 
        Console.WriteLine(sum);
    }
}
