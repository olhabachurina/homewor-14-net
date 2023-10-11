// See https://aka.ms/new-console-template for more information


CreditCard myCreditCard = new CreditCard("777777777777777", "Petrenko Petro", DateTime.Now.AddYears(3), 7777, 1000);

myCreditCard.AccountCredited += (sender, amount) =>
{
    Console.WriteLine($"Account replenished by {amount} at {DateTime.Now}.");
};

myCreditCard.AccountDebited += (sender, amount) =>
{
    Console.WriteLine($"Debited from account {amount} at {DateTime.Now}.");
};

myCreditCard.CreditStarted += (sender, amount) =>
{
    Console.WriteLine($"Started using credit funds: {amount} at {DateTime.Now}.");
};

myCreditCard.LimitReached += (sender, amount) =>
{
    Console.WriteLine($"The specified amount limit has been reached {amount} at {DateTime.Now}.");
};

myCreditCard.Credit(500);
myCreditCard.Debit(200);
myCreditCard.StartCredit(1000);
myCreditCard.Debit(800); 


myCreditCard.ChangePin();// Изменение PIN-кода