using AccountsLib;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Test DayTime
        DayTime date = new DayTime(0);
        Console.WriteLine("Testing DayTime:");
        Console.WriteLine(date);  // 2023-01-01 00:00
        date += 518400;
        Console.WriteLine(date);  // 2024-01-01 00:00
        date += 43200;
        Console.WriteLine(date);  // 2024-02-01 00:00
        date += 1440;
        Console.WriteLine(date);  // 2024-02-02 00:00
        date += 60;
        Console.WriteLine(date);  // 2024-02-02 01:00
        date += 35;
        Console.WriteLine(date);  // 2024-02-02 01:35

        Console.WriteLine("\nTesting Util.Now:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(Util.Now);
        }

        Console.WriteLine("\nTesting AccountException:");
        try
        {
            throw new AccountException(AccountExceptionType.PASSWORD_INCORRECT);
        }
        catch (AccountException e)
        {
            Console.WriteLine("Caught: " + e.Message);
        }

        Console.WriteLine("\nTesting LoginEventArgs:");
        LoginEventArgs login = new LoginEventArgs("Narendra", true, LoginEventType.Login);
        Console.WriteLine($"{login.PersonName} {login.EventType} Success: {login.Success} at {login.Time}");

        Console.WriteLine("\nTesting TransactionEventArgs:");
        TransactionEventArgs tx = new TransactionEventArgs("Ilia", 150.75m, true);
        Console.WriteLine($"{tx.PersonName} Transaction ${tx.Amount} Success: {tx.Success} at {tx.Time}");
    }
}
