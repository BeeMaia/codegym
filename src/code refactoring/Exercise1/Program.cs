Console.WriteLine("Welcome to the Spaghetti Code Gym!");
 
int choice;
do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Calculate factorial");
    Console.WriteLine("2. Calculate Fibonacci");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");
    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter a number to calculate its factorial: ");
            int num1 = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num1; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial of {num1} is: {factorial}");
            break;
        case 2:
            Console.Write("Enter the length of the Fibonacci sequence: ");
            int length = int.Parse(Console.ReadLine());
            int[] fib = new int[length];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < length; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            Console.WriteLine("Fibonacci sequence:");
            foreach (int num in fib)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine("Exiting the program...");
            break;
        default:
            Console.WriteLine("Invalid choice! Please try again.");
            break;
    }
} while (choice != 3);
