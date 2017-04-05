using System;

class TrainingLab
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine()) * 100;
        double height = double.Parse(Console.ReadLine()) * 100;

        int cols = ((int)height - 100) / 70;
        int rows = (int)width / 120;

        //Alternative:
        //double cols = Math.Truncate((height - 100) / 70);
        //double rows = Math.Truncate(width / 120);

        int seats = rows * cols - 3;

        Console.WriteLine(seats);
    }
}
