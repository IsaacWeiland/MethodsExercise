namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Add(3, 4));
            Console.WriteLine(Mult(6, 20, 2));
            Console.WriteLine(Sub(10, 4));
            Console.WriteLine(Div(64, 8));
            MadLib();
        }

        static void MadLib()
        {
            Console.WriteLine("Please enter a name. \n");
            string name = Console.ReadLine();
            Console.WriteLine("\nPlease enter an animal.\n");
            string animal = Console.ReadLine();
            Console.WriteLine("\nPlease enter your favorite beverage.\n");
            string drink = Console.ReadLine();
            Console.WriteLine("\nPlease enter a day of the week.\n");
            string day = Console.ReadLine();
            Console.WriteLine("\nPlease enter a holiday.\n");
            string celebration = Console.ReadLine();
            Console.WriteLine($"{name} was a {animal} who loved {celebration}.\nWhen it came around this year on {day} " +
                              $"it got out its favorite drink, {drink}.");
        }

        static int Add(params int[] a)
        {
            int sum = 0;
            foreach (int value in a)
            {
                sum += value;
            }
            return sum;
        }

        static int Mult(params int[] a)
        {
            int sum = 1;
            foreach (int value in a)
            {
                sum *= value;
            }
            return sum;
        }

        static int Sub(int a, int b)
        {
            return  a - b;
        }

        static int Div(int a, int b )
        {
            return a / b;
        }
    }
}
