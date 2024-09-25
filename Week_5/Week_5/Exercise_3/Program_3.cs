using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5.Exercise_3
{

    class Account
    {
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Balance { get; set; }

        public Account()
        {
            AccountId = 0;
            FirstName = "";
            LastName = "";
            Balance = 0;
        }
        public Account(int accountId, string firstName, string lastName, int balance)
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
    class AccountList
    {
        private ArrayList accountList = new ArrayList();

        public void AddNewAccount()
        {
            Account account = new Account();
            account.FillInfo();
            accountList.Add(account);
        }

        public void Report()
        {
            foreach (Account account in accountList)
            {
                account.Query();
            }
        }
        public void SaveFile()
        {
            Console.Write("Input file name to save: ");
            string fileName = Console.ReadLine()!;
            // read file
            try
            {
                // Tạo luồng truy cập file
                FileStream output = new FileStream(fileName, FileMode.CreateNew, FileAccess.Write);
                // Thiết lập writer
                StreamWriter writer = new StreamWriter(output);
                foreach (Account account in accountList)
                {
                    // Lưu các thông tin của Account trên 1 dòng, phân cách nhau bằng dấu ,
                    writer.WriteLine($"{account.AccountId}, {account.FirstName}, {account.LastName}, {account.Balance}");
                }
                // đóng kết nối
                writer.Close();
                output.Close();
                // File được lưu tại : .\Week_5\Week_5\bin\Release\net8.0\ hoặc .\Week_5\Week_5\bin\Debug\net8.0\
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void loadFile()
        {
            // Đọc tên file chứa dữ liệu
            Console.WriteLine("Input file name to load: ");
            string fileName = Console.ReadLine()!;

            // Xóa danh sách
            accountList.Clear();
            try
            {
                // Tạo luồng đọc file
                FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                string str;
                // đọc qua từng dòng, kết thúc khi chuỗi null
                while ((str = reader.ReadLine()!) != null)
                {
                    // Tách chuỗi đọc ra thành các chuỗi con có phân cách nhau dấu ,
                    string[] list = str.Split(",");
                    // Tạo đối tượng Account mới
                    Account account = new Account(int.Parse(list[0]), list[1], list[2], int.Parse(list[3]));
                    accountList.Add(account);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    internal class Program_3
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            AccountList accountList = new AccountList();

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
                        accountList.loadFile();
                        break;
                    case "Report":
                        accountList.Report();
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
