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
    public int getId() 
    {
        return this.Id;
    }
    public int check_Balance()
    {
        return Balance;
    }

    public int upgrade_balance_atm( int amount)
    {
        int new_balance = Balance - amount;

        return new_balance;
    }
    public int uptade_balance_atm(int amount)
    {
        int new_balance = Balance + amount;

        return new_balance;
    }
    public override string ToString()
    {
        return "[" + "Num cajero: " + Id + " Balance cajero: " + Balance + "]";
    }
}