namespace CSharpAssignments
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter target number:");
            int targetNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\nOptions are:");
            Console.WriteLine("1  Even Numbers");
            Console.WriteLine("2 Odd Numbers");
            int options = int.Parse(Console.ReadLine());

            switch (options)
            {
                case 1:
                    PrintEvenNumbers(targetNumber);
                    break;
                case 2:
                    PrintOddNumbers(targetNumber);
                    break;
            }
        }
        static void PrintEvenNumbers(int targetNumber)
        {
            Console.WriteLine("\nThe Even Numbers are:");
            for (int i = 0; i < targetNumber; i =i+2)
            {
                Console.WriteLine(i);
            }
        }
        static void PrintOddNumbers(int targetNumber)
        {
            Console.WriteLine("\nThe Odd Numbers are:");
            for (int i = 1; i < targetNumber; i=i+2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
