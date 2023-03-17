using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OpcionIncorrectaException : Exception
{
    public OpcionIncorrectaException() : base() {}
    public OpcionIncorrectaException(string message) : base(message)
    {
        
    }
}