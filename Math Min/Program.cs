//сумиране на числа и изписване на най-малкото

    {
        //Math Min
        Console.WriteLine("Write the numbers that you need to sum!");


        int min = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int z = int.Parse(Console.ReadLine());


        int smallest = Math.Min(min, Math.Min(b, Math.Min(c, Math.Min(d, Math.Min(x, Math.Min(y, z))))));


        Console.WriteLine("The smallest number is: " + smallest);
    }


