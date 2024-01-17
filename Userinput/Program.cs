namespace Userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, language, position;
            Console.WriteLine("what is your name:  ?");
            name = Console.ReadLine();
            Console.WriteLine("what programing language do you know: ?");
            language = Console.ReadLine();
            Console.WriteLine("what is your position: ?");
            position = Console.ReadLine();

            Console.WriteLine($"Why did {name} choose {language}? Because they wanted to be a {position}!\n");






            double sum = Multiply(3, 4, 22, 33, 4, 1);
            Console.WriteLine(sum);
        }
        public static double Multiply(params double[] prices)
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
    }
}
