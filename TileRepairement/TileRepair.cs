using System;

class TileRepair
{
    static void Main(string[] args)
    {
        // Ground length
        int n = int.Parse(Console.ReadLine());
        // Tile width
        double w = double.Parse(Console.ReadLine());
        // Tile length
        double h = double.Parse(Console.ReadLine());
        // Bench width
        int a = int.Parse(Console.ReadLine());
        // Bench length
        int b = int.Parse(Console.ReadLine());

        int area = n * n;
        int bench = a * b;
        int areaToRepair = area - bench;

        double tiles = areaToRepair / (w * h);

        double time = tiles * 0.2;

        Console.WriteLine(tiles);
        Console.WriteLine(time);

    }
}
