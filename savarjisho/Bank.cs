using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking
{
    internal class Bank
    {

        private List<BankAccount> accounts = new List<BankAccount>();

        public void CreateAccount(string accountNumber, string accountHolder, decimal initialBalance)
        {
            BankAccount newAccount = new BankAccount(accountNumber, accountHolder, initialBalance);
            accounts.Add(newAccount);
            Console.WriteLine($"Account for {accountHolder} created successfully.");
        }

        public BankAccount GetAccount(string accountNumber)
        {
            foreach (var account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return account;
                }
            }
            return null;
        }

        public void ListAccounts()
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"Account: {account.AccountNumber}, Holder: {account.AccountHolder}, Balance: {account.GetBalance()}");
            }
        }

    }
}
