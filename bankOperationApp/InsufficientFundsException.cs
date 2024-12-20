using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string meessage): base(meessage)
    {
        
    }
}