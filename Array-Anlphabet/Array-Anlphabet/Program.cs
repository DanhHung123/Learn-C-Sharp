
using System;
namespace array
{
    class anphabet
    {
        static void Main(string[] args)
        {
            int[] ID = new int[3];
            string[] name = new string[3];
            string[] address = new string[3];
            string[] namOfState = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the ID of author : ");
                ID[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name of author : ");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter the address of author : ");
                address[i] = Console.ReadLine();
                Console.WriteLine("Enter the name of state : ");
                namOfState[i] = Console.ReadLine();
                Console.WriteLine("\n");
            }

            Console.WriteLine("Details of the authors :");
            Console.WriteLine("Author Id\tName\t\tAddress\t\tState");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{ID[i]}\t\t{name[i]}\t\t{address[i]}\t\t{namOfState[i]}");
            }

            Array.Sort(name);
            Console.WriteLine("Author name after sorting :");
            foreach (var n in name)
            {
                Console.WriteLine(n);
            }
        }
    }
}