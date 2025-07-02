using System;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("**** Menu ****");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter first number: ");
                    float a1 = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    float b1 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Result: " + calc.Add(a1, b1));
                    break;

                case "2":
                    Console.Write("Enter first number: ");
                    float a2 = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    float b2 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Result: " + calc.Subtract(a2, b2));
                    break;

                case "3":
                    Console.Write("Enter first number: ");
                    float a3 = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    float b3 = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Result: " + calc.Multiply(a3, b3));
                    break;

                case "4":
                    Console.Write("Enter first number: ");
                    float a4 = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    float b4 = Convert.ToSingle(Console.ReadLine());
                    if (b4 != 0)
                        Console.WriteLine("Result: " + calc.Divide(a4, b4));
                    else
                        Console.WriteLine("Error: Division by zero.");
                    break;

                case "5":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine(); 
        }
    }
}


