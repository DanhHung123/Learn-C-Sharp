using System;
class Ex2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1nd number: ");
        int s1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd number: ");
        int s2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 3nd number: ");
        int s3 = Convert.ToInt32(Console.ReadLine());
        int max = s1;

        if (s2 > s1)
        {
            max = s2;
        }
        if (s3 > s2)
        {
            max = s3;
        }
        Console.WriteLine("Number Max: {0} ",max);

    }
}
