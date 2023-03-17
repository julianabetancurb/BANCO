using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ATM

{
    public int Balance;
    public int Id;

    //metodo constructor
    public ATM(int id, int balance)
    {
        this.Id = id;
        this.Balance = balance;

    }
    public int check_Balance()
    {
        return Balance;
    }

    public int upgrade_balance(int new_balance, int amount)
    {
        this.Balance = new_balance;

        if (new_balance != 0)
        {
            new_balance += Balance + amount;
        }
        return new_balance;
    }
    
}