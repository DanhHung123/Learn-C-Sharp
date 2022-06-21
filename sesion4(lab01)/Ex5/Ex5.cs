using System;
class Ex5
{
    static void Main(string[] args)
    {

        Console.WriteLine("Write a program to print the factorials of the integers from 1 to 20");
        long gt=1;
        for (int i = 1; i <= 20; i++,gt*=i)
        {
            Console.WriteLine($"Factorials {i}: {gt}");
        }
        

    }
}
