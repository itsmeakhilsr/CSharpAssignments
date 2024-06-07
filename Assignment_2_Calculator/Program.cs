namespace Assignment_2_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.WriteLine("Select an operation to perform :");
                Console.WriteLine("1  Add");
                Console.WriteLine("2  Subtract");
                Console.WriteLine("3  Multiply");
                Console.WriteLine("4  Divide");
                Console.WriteLine("5  Exit operatio\n\n");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter first number: ");
                int FirstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter  second number: ");
                int SecondNumber= int.Parse(Console.ReadLine());

                int result = 0;
                bool validOperation = true;

                switch (choice)
                {
                    case 1:
                    result = FirstNumber + SecondNumber;
                        Console.WriteLine($"Result= {result}");
                        break;
                    case 2:
                        result = FirstNumber - SecondNumber;
                        Console.WriteLine($"Result= {result}");
                    break;
                    case 3:
                        result = FirstNumber* SecondNumber;
                        Console.WriteLine($"Result={result}");
                        break;
                    case 4:
                        if (SecondNumber != 0)
                        {
                            result = FirstNumber/ SecondNumber;
                            Console.WriteLine($"Result= {result}");
                        }
                        else
                        {
                            Console.WriteLine("Division by zero is not possible");
                        }
                        break;
                    default:
                        validOperation = false;
                        Console.WriteLine("Invalid operation ");
                        break;

                }
                if (validOperation)
                {
                    Console.WriteLine("Continue to perform ? yes=1 ");
                    int Choice = int.Parse(Console.ReadLine());
                    continueCalculating = (Choice == 1);
                }
            }
        }
        
    }
}
