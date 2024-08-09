namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib();
        }

        static void MadLib()
        {
            Console.WriteLine("Enter name. \n");
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
    }
}
