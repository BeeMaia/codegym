namespace Exercise2;

public class Program
{
    private static Dictionary<int, decimal> accounts = new Dictionary<int, decimal>();

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Spaghetti Banking System!");

        int choice;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter account number: ");
                    int accountNumber = int.Parse(Console.ReadLine());
                    if (accounts.ContainsKey(accountNumber))
                    {
                        Console.WriteLine("Account already exists!");
                    }
                    else
                    {
                        Console.Write("Enter initial balance: ");
                        decimal initialBalance = decimal.Parse(Console.ReadLine());
                        accounts.Add(accountNumber, initialBalance);
                        Console.WriteLine("Account created successfully!");
                    }
                    break;
                case 2:
                    Console.Write("Enter account number: ");
                    int depositAccount = int.Parse(Console.ReadLine());
                    if (!accounts.ContainsKey(depositAccount))
                    {
                        Console.WriteLine("Account does not exist!");
                    }
                    else
                    {
                        Console.Write("Enter deposit amount: ");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        accounts[depositAccount] += depositAmount;
                        Console.WriteLine("Deposit successful!");
                    }
                    break;
                case 3:
                    Console.Write("Enter account number: ");
                    int withdrawAccount = int.Parse(Console.ReadLine());
                    if (!accounts.ContainsKey(withdrawAccount))
                    {
                        Console.WriteLine("Account does not exist!");
                    }
                    else
                    {
                        Console.Write("Enter withdrawal amount: ");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        if (withdrawAmount > accounts[withdrawAccount])
                        {
                            Console.WriteLine("Insufficient funds!");
                        }
                        else
                        {
                            accounts[withdrawAccount] -= withdrawAmount;
                            Console.WriteLine("Withdrawal successful!");
                        }
                    }
                    break;
                case 4:
                    Console.Write("Enter account number: ");
                    int checkBalanceAccount = int.Parse(Console.ReadLine());
                    if (!accounts.ContainsKey(checkBalanceAccount))
                    {
                        Console.WriteLine("Account does not exist!");
                    }
                    else
                    {
                        Console.WriteLine($"Balance: {accounts[checkBalanceAccount]}");
                    }
                    break;
                case 5:
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        } while (choice != 5);
    }
}