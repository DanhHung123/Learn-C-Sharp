using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Product
{
    // Fields
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    // Contructor
    public Product(int Id,string Name, double Price)
    {
        this.Id = Id;
        this.Name = Name;
        this.Price = Price;
    }

    // Abstract method
    public abstract double computeTax();
}



// Class book
class Book: Product
{
    // Contructor
    public Book(int id, string name, double price) : base(id,name,price)
    {

    }

    // Override computeTax()
    public override double computeTax()
    {
        return this.Price * 0.05;
    }
}


// Class phone
class Phone: Product
{
    // Contructor
    public Phone(int id, string name, double price) : base(id, name, price)
    {

    }

    // Override computeTax()
    public override double computeTax()
    {
        return this.Price * 0.1;
    }
}



// Class test
class Program
{
    static void Main(string[] args)
    {
        // Array Product (3 book, 2 phone)
        Product[] product = new Product[5];
        product[0] = new Book(1, "Dac nhan tam", 300); 
        product[1] = new Book(2, "Cha giau cha ngheo",450);
        product[2] = new Book(3, "Nha gia kim", 500);
        product[3] = new Phone(4, "Iphone 10", 2220);
        product[4] = new Phone(5, "Samsung S20 Utra", 1990);

        // Total Tax
        double totalTax = 0;
        foreach(var p in product)
        {
            Console.WriteLine($"{p.Name}: {p.computeTax()}$");
            totalTax += p.computeTax();
        }
        // Print total tax
        Console.WriteLine();
        Console.WriteLine($"=> Total tax: {totalTax}$" );
    }
}
