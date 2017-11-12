namespace _03.BankAccountTest
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var accounts = new Dictionary<int, BankAccount>();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                var commandArgs = command.Split();
                var commandType = commandArgs[0];
                var id = int.Parse(commandArgs[1]) - 1;

                if (commandType == "Create")
                {
                    if (accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        accounts[id] = new BankAccount();
                        accounts[id].ID = id + 1;
                        accounts[id].Balance = 0;
                    }
                }
                else if (commandType == "Deposit")
                {
                    var amount = int.Parse(commandArgs[2]);

                    if (!accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        accounts[id].Deposit(amount);
                    }
                }
                else if (commandType == "Withdraw")
                {
                    var amount = int.Parse(commandArgs[2]);

                    if (!accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        accounts[id].Withdraw(amount);
                    }
                }
                else
                {
                    if (!accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        Console.WriteLine(accounts[id].ToString());
                    }
                }

            }
        }
    }
}