using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SucursalVirtual : ATM
{
    public SucursalVirtual(int balance, int id, List<ATM> atms): base(balance, id)
    {
        this.Balance = balance;
        this.Id = id;
    }


    public int virtual_withdraw(int monto)
    {
        return this.Balance -= monto;
    }
    public void virtualdeposit(int monto) //depositar dinero a el saldo actual
    {
        if (monto != 0)
        {
            this.Balance += monto;
        }
    }
}
    
