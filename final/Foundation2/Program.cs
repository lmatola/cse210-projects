using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine();
        Order c1 = new Order("Jonathan Smith", "20 Cooper Square", "New York", "NY 10003", "USA");
        c1.AddProduct("Handmade Men's Solid Leather Belts - 1 1/2 Inch", "FP439", 29.75, 2);
        c1.AddProduct("Muggiez Drink Handles", "JK163", 18.99, 5);
        c1.AddProduct("The Caulking Finger", "PLT53", 23.45, 2);
        c1.AddProduct("Leather Compact Holster", "HDNS4", 43.99, 1);

        c1.PrintPackingSlip();

        Console.WriteLine();

        c1.PrintShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${c1.TotalOrderPrice()}");

        Console.WriteLine();

        Console.WriteLine("----------------------------------");

        Console.WriteLine();
        Order c2 = new Order("Alexander Arnald", "27 John Street", "WINCHESTER", "SO23 9AP", "UK");
        c2.AddProduct("Garden Path Soap Palm Wax Candles", "IGSC63", 5.26, 3);
        c2.AddProduct("16 OZ . Beach Tumblers with Lids", "CMB77", 58.99, 2);
        c2.AddProduct("30 Pack Plastic Clothes Hangers", "AGC00", 11.58, 1);
        c2.AddProduct("6 Well Donut Baking Pan", "GWM45", 56.47, 1);

        c2.PrintPackingSlip();

        Console.WriteLine();

        c2.PrintShippingLabel();

        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${c2.TotalOrderPrice()}");
        Console.WriteLine();
        
    }
}