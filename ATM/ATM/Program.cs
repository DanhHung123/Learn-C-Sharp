using System;

class Atm
{
    int balance;
    static void Main(string[] args)
    {
        int username, password;
        int balance = 5000,id = 0;
        int chose;
        Console.WriteLine("Enter username:");
        username = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter password:");
        password = Convert.ToInt32(Console.ReadLine());
        if (Login(username, password) == 1)
        {
            do
            {
                Menu();
                Console.WriteLine("Enter chose:");
                chose = Convert.ToInt32(Console.ReadLine());
                switch(chose)
                {
                    case 1:
                        Console.WriteLine("=Withdraw=");
                        Console.WriteLine("Enter num:");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Withdraw(num, balance);
                        break;
                    case 2:
                        Console.WriteLine("=Transfer=");
                        Console.WriteLine("Nhap so tien chuyen:");
                        int numc = Convert.ToInt32(Console.ReadLine());
                        Transfer(ref id,numc,balance);
                        break;
                    case 3:
                        Console.WriteLine("=Check=");
                        Console.WriteLine($"So du hien tai cua ban : {balance}");
                        break;
                }

            } while (true);
        }
        else
        {
            Console.WriteLine("Login faled !");
        }
    }

    static void Menu()
    {
        Console.WriteLine("1. Withdraw");
        Console.WriteLine("2. Transfer");
        Console.WriteLine("3. Check");
        Console.WriteLine("4. Exit");
    }
    static int Login(int username, int pass)
    {
        if(username == 123 && pass == 456)
        {
            Console.WriteLine("Login sucess !");
            return 1;
        }else
        {
            return 0;
        }

    }

    static int Withdraw(int num,int balance) 
    {
        if(num > balance)
        {
            Console.WriteLine("So du khong du");
        }else if(num % 50 == 0 && num > 3000)
        {
            Console.WriteLine("So tien phai nho hon 3M va boi cua 50");
        }
        else
        {
            balance -= num;
            Console.WriteLine($"Rut thanh cong : {num}");
            Console.WriteLine($"So du : {balance}");
        }
        return balance;
    }

    static int Transfer(ref int id, int num, int balance)
    {
        if (num > balance)
        {
            Console.WriteLine("So du khong du");
        }
        else
        {
            balance -= num;
            id += num;
            Console.WriteLine($"Chuyen tien thanh cong : {num}");
            Console.WriteLine($"So du : {balance}");
        }
        return balance;
    }

}

