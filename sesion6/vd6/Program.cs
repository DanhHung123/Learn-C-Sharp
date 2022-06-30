class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal constructor without parameters");
    }
    public Animal(String name)
    {
        Console.WriteLine("Animal constructor with a string parameter");
    }
}
class Canine : Animal
{
    //base() takes a string value called "Lion"
    public Canine() : base("Lion")
    {
        Console.WriteLine("Derived Canine");
    }
}
class Details
{
    static void Main(String[] args)
    {
        Canine objCanine = new Canine();
    }
}