using System;

class VegetableMarket
{
    static void Main()
    {
        double vegPrice = double.Parse(Console.ReadLine());
        double fruitsPrice = double.Parse(Console.ReadLine());
        int vegPerKg = int.Parse(Console.ReadLine());
        int fruitsPerKg = int.Parse(Console.ReadLine());

        double vegTotal = vegPrice * vegPerKg;
        double fruitTotal = fruitsPrice * fruitsPerKg;

        Console.WriteLine((fruitTotal + vegTotal) / 1.94);
    }
}
