using System;
using banking;

namespace banking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bank bank = new Bank();

            while (true)
            {
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. List Accounts");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter account number: ");
                        string accNumber = Console.ReadLine();
                        Console.Write("Enter account holder name: ");
                        string holder = Console.ReadLine();
                        Console.Write("Enter initial balance: ");
                        decimal balance = decimal.Parse(Console.ReadLine());
                        bank.CreateAccount(accNumber, holder, balance);
                        break;

                    case 2:
                        Console.Write("Enter account number: ");
                        string depAccNumber = Console.ReadLine();
                        var account = bank.GetAccount(depAccNumber);
                        if (account != null)
                        {
                            Console.Write("Enter amount to deposit: ");
                            decimal depositAmount = decimal.Parse(Console.ReadLine());
                            account.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case 3:
                        Console.Write("Enter account number: ");
                        string withAccNumber = Console.ReadLine();
                        var accountToWithdraw = bank.GetAccount(withAccNumber);
                        if (accountToWithdraw != null)
                        {
                            Console.Write("Enter amount to withdraw: ");
                            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                            accountToWithdraw.Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case 4:
                        bank.ListAccounts();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }


        }

    }
}