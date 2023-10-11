using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class CreditCard
{
    public delegate void AccountOperationHandler(CreditCard sender, decimal amount);
    public delegate void PinChangedHandler(CreditCard sender);

    public event AccountOperationHandler AccountCredited;
    public event AccountOperationHandler AccountDebited;
    public event AccountOperationHandler CreditStarted;
    public event AccountOperationHandler LimitReached;
    public event PinChangedHandler PinChanged;
}
