using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(new long[] { 10, 100, 20, 50, 30 });
            bank.Withdraw(3, 10);
            bank.Transfer(5, 1, 20);
            bank.Deposit(5, 20);
            bank.Transfer(3, 4, 15);
            bank.Withdraw(10, 50);
        }
        public class Bank
        {
            long[] bank;
            public Bank(long[] balance)
            {
                int n = balance.Length;
                bank = new long[n];
                Array.Copy(balance, bank, n);
            }
            public bool Transfer(int account1, int account2, long money)
            {
                if (bank.Length >= account1 && bank.Length >= account2 && bank[account1 - 1] >= money)
                {
                    if (bank[account1 - 1] < money)
                        return false;
                    bank[account1 - 1] -= money;
                    bank[account2 - 1] += money;
                    Console.WriteLine($"{money} were transfered from account {account1} to account {account2}");
                    return true;
                }
                Console.WriteLine($"Could not transfer the money");
                Console.WriteLine(String.Join(",", bank));
                return false;
            }

            public bool Deposit(int account, long money)
            {
                if (bank.Length >= account)
                {
                    bank[account - 1] += money;
                    Console.WriteLine($"{money} were deposited to account {account}");
                    Console.WriteLine(String.Join(",", bank));
                    return true;
                }
                Console.WriteLine($"Could not deposit the money");
                Console.WriteLine(String.Join(",", bank));
                return false;
            }

            public bool Withdraw(int account, long money)
            {
                if (bank.Length >= account)
                {
                    if (bank[account - 1] < money)
                        return false;

                    bank[account - 1] -= money;
                    Console.WriteLine($"{money} were withdrawn from account {account}");
                    Console.WriteLine(String.Join(",", bank));
                    return true;
                }
                Console.WriteLine($"Could not withdraw the money");
                Console.WriteLine(String.Join(",", bank));
                return false;
            }
        }
    }
}
