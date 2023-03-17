using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UdemBank
   {
    int balance_banco = 100000000;
    Administrator administrator = new Administrator(10000000, "password");

    public UdemBank(int balance_banco) 
    { }
    public int getBalancebanco()
    {
        balance_banco = 1000000000;
        return balance_banco;
    }
   }

