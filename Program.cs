namespace DeclaringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Personalized Poem Generator");

            Console.WriteLine("Enter your name: ");
            string UserName = Console.ReadLine();

            Console.WriteLine("Enter your color:  ");
            string UserColor = Console.ReadLine();

            Console.WriteLine("Enter an emotion:  ");
            string UserEmotion = Console.ReadLine();

            Console.WriteLine("Enter a place you like : ");
            string UserPlace = Console.ReadLine();

            Console.WriteLine("/n ---------HERE IS YOUR PERSONALIZED POEM-------");

            Console.WriteLine($"{UserName} with eyes as {UserColor} as the sky\n");
            Console.WriteLine($"in the realm of {UserPlace} where {UserEmotion} fly");
            Console.WriteLine($"Feeling {UserEmotion}, a tale to unfold");
            Console.WriteLine($"in the land where dreams take flight A journey begins for {UserName} in the soft moonlight");
            Console.WriteLine($"{UserName} feels {UserEmotion}, a heart's gentle song,");
            Console.WriteLine($"{UserName} with eyes as {UserColor} as the sky");
            Console.WriteLine($"in the realm of {UserPlace} where {UserEmotion} fly");
            Console.WriteLine($"in the land where dreams take flight A journey begins for {UserName} in the soft moonlight");

            Console.WriteLine(" Thanks for using personlized peom\n");

        }
    }
    }
