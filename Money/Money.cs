using System;

class Money
{
    static void Main()
    {

        decimal bitcoins = int.Parse(Console.ReadLine());
        decimal yuans = decimal.Parse(Console.ReadLine());
        decimal commission = decimal.Parse(Console.ReadLine()) / 100.00m;

        decimal bitcoinsToLeva = bitcoins * 1168;
        decimal yuansToDollars = yuans * 0.15m;
        decimal dollarsToLeva = yuansToDollars * 1.76m;

        decimal leva = dollarsToLeva + bitcoinsToLeva;
        decimal euro = leva / 1.95m;

        euro -= commission * euro;

        Console.WriteLine(euro);
    }

    
}
