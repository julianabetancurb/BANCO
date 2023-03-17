using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Client : User //clase hija
{

    public int Balance;
    public string Account_number;
    public string type_client;
    public Client(int id, string password, string type_client) : base(id, password) //hereda contructor
    {

        this.Balance = 100000;
        this.type_client = type_client;
        
        this.Account_number = GetAccountNumber();
    }
    public string getTypeClient
    {
         return type_client; 
    }
    public string GetAccountNumber()
    {
        return Account_number;
    }
    public void setTypeClient(string newType)
    {
        this.type_client = newType;
    }
    public int getBalance
    {
        get { return this.Balance; }
    }




    public bool verify_withdraw(int monto) //verifica si el monto a retirar es menor o igual que el saldo del cliente
    {
        if (monto <= Balance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int withdraw(int monto) //retirar dinero
    {
        if (verify_withdraw(monto))
        {
            Balance -= monto;
        }
        return Balance;
    }
    public void deposit(int monto) //depositar dinero a el saldo actual
    {
        if (monto != 0)
        {
            this.Balance += monto;
        }
    }
    public void transfer(int monto, Client persona) //trasnferir dinero a otro cliente
    {
        if (monto != 0)
        {
            this.Balance -= monto;
            persona.deposit(monto);
        }
    }
}