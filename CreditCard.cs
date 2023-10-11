using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public partial class CreditCard
{
    public string CardNumber { get; private set; }
    public string OwnerName { get; private set; }
    public DateTime ExpiryDate { get; private set; }
    private int pin;
    public decimal CreditLimit { get; private set; }
    public decimal Balance { get; private set; }

    public CreditCard(string cardNumber, string ownerName, DateTime expiryDate, int pin, decimal creditLimit)
    {
        CardNumber = cardNumber;
        OwnerName = ownerName;
        ExpiryDate = expiryDate;
        this.pin = pin;
        CreditLimit = creditLimit;
        Balance = 0;
    }
}