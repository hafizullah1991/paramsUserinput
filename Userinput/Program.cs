namespace System;

internal class Program
{
    static void Main(string[] args)
    {
        // Exercise 1 

        string name, language, position;
        Console.WriteLine("what is your name:  ?");
        name = Console.ReadLine();
        Console.WriteLine("what programing language do you know: ?");
        language = Console.ReadLine();
        Console.WriteLine("what is your position: ?");
        position = Console.ReadLine();

        Console.WriteLine($"Why did {name} choose {language}? Because they wanted to be a {position}!\n");




        // Exercise 2 Add and subtract

        double total = AddNumber(3, 4, 22, 33, 4, 1);
        Console.WriteLine(total);

        int result = SubTract(14, 12); 
        Console.WriteLine(result);
    }
    public static double AddNumber(params double[] prices)
    {
        double Total = 0;
        {
            foreach (var pr in prices)
            {
                Total += pr;
            }
        }
        return Total;
    }
   

public static int SubTract(int x , int y)
    {
        return x - y;
    }


}
