using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

public partial class CreditCard
{
    public void Credit(decimal amount)
    {
        Balance += amount;
        AccountCredited?.Invoke(this, amount);
    }

    public void Debit(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            AccountDebited?.Invoke(this, amount);

        }
        else
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Insufficient funds in the account!!!");
            Console.ResetColor();
        }
    }

    public void StartCredit(decimal amount)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        CreditStarted?.Invoke(this, amount);
        Console.ResetColor();
    }

    public void ChangePin()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Enter new PIN-code:");

        // Здесь добавьте код для ввода нового PIN-кода с клавиатуры
        if (int.TryParse(Console.ReadLine(), out int newPin))
        {
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            pin = newPin;
            PinChanged?.Invoke(this);
            Console.WriteLine("PIN code changed", 0); // 0, так как в данном случае сумма не имеет смысла
            Console.ResetColor();
        }
        else
        {
            Console.ResetColor();
            Console.WriteLine("Invalid PIN code.");
        }
    }
}