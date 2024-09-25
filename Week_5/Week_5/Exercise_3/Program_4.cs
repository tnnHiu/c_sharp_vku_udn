using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Week_5.Exercise_3
{

    [Serializable]
    class Account1
    {
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Balance { get; set; }

        public Account1()
        {
            AccountId = 0;
            FirstName = "";
            LastName = "";
            Balance = 0;
        }
        public Account1(int accountId, string firstName, string lastName, int balance)
        {
            AccountId = accountId;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public void Query()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine($"Account ID: {AccountId}");
            Console.WriteLine($"First name: {FirstName}");
            Console.WriteLine($"Last name: {LastName}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine("---------------------");
        }
        public void FillInfo()
        {
            Console.Write("Account ID: ");
            AccountId = int.Parse(Console.ReadLine()!);
            Console.Write("First name: ");
            FirstName = Console.ReadLine()!;
            Console.Write("Last name: ");
            LastName = Console.ReadLine()!;
            Console.Write("Balance: ");
            Balance = int.Parse(Console.ReadLine()!);
        }


    }
    class AccountIdComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Account1 accountX && y is Account1 accountY)
            {
                return accountX.AccountId.CompareTo(accountY.AccountId);
            }
            throw new ArgumentException("Both parameters should be of type Account");
        }
    }

    class FirstnameComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Account1 accountX && y is Account1 accountY)
            {
                return accountX.FirstName.CompareTo(accountY.FirstName);
            }
            throw new ArgumentException("Both parameters should be of type Account");
        }
    }
    class BalanceComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Account1 accountX && y is Account1 accountY)
            {
                return accountX.Balance.CompareTo(accountY.Balance);
            }
            throw new ArgumentException("Both parameters should be of type Account");
        }
    }

    class AccountList1
    {
        private ArrayList accountList = new ArrayList();

        public void AddNewAccount()
        {
            Account1 account = new Account1();
            account.FillInfo();
            accountList.Add(account);
        }

        public void Report()
        {
            foreach (Account1 account in accountList)
            {
                account.Query();
            }
        }
        public void SaveFile()
        {
            Console.Write("Input file name to save: ");
            string fileName = Console.ReadLine()!;
            try
            {
                // Lưu dưới dạng Json
                string jsonString = JsonSerializer.Serialize(accountList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(fileName, jsonString);
                // File được lưu tại : .\Week_5\Week_5\bin\Release\net8.0\ hoặc .\Week_5\Week_5\bin\Debug\net8.0\

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void LoadFile()
        {
            Console.Write("Input file name to load: ");
            string fileName = Console.ReadLine()!;
            accountList.Clear();

            try
            {
                // Đọc nội dung file JSON
                string jsonString = File.ReadAllText(fileName);
                var accounts = JsonSerializer.Deserialize<List<Account1>>(jsonString);

                if (accounts != null)
                {
                    foreach (var account in accounts)
                    {
                        accountList.Add(new Account1(account.AccountId, account.FirstName, account.LastName, account.Balance));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void RemoveAccount()
        {
            Console.Write("Account ID to remove: ");
            int accountIdToRemove = int.Parse(Console.ReadLine()!);

            Account1 tempAccount = new Account1 { AccountId = accountIdToRemove };

            int index = accountList.BinarySearch(tempAccount, new AccountIdComparer());

            if (index >= 0)
            {
                accountList.RemoveAt(index);
                Console.WriteLine($"Account ID {accountIdToRemove} has been removed.");
            }
            else
            {
                Console.WriteLine($"Account ID {accountIdToRemove} not found.");
            }
        }
        public void SortByAccountId()
        {
            accountList.Sort(new AccountIdComparer());
        }
        public void SortByBalance()
        {
            accountList.Sort(new BalanceComparer());
        }
        public void SortByFirstName()
        {
            accountList.Sort(new FirstnameComparer());
        }
    }

    internal class Program_4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            AccountList1 accountList = new AccountList1();

            while (true)
            {
                string command = Console.ReadLine()!;
                switch (command)
                {
                    case "Add":
                        accountList.AddNewAccount();
                        break;
                    case "Save":
                        accountList.SaveFile();
                        break;
                    case "Load":
                        accountList.LoadFile();
                        break;
                    case "Report":
                        accountList.Report();
                        break;
                    case "Remove":
                        accountList.RemoveAccount();
                        break;

                    case "SortID":
                        accountList.SortByAccountId();
                        break;
                    case "SortFirstName":
                        accountList.SortByFirstName();
                        break;
                    case "SortBalance":
                        accountList.SortByBalance();
                        break;
                    case "Exit":
                        return;
                    default:
                        Console.WriteLine("Input command again!");
                        break;
                }
            }
        }
    }
}




