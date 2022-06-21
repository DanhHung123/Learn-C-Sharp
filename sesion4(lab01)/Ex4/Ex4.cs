using System;
class Ex4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        int dem = 1;

        for(int n =1;dem<=9;n++)
        {
            if (n % number == 0)
            {
                Console.WriteLine(n);
                dem++;
            }
        }
    }
}
