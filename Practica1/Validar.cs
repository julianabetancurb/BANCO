using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Validar
{
    Administrator adm = new Administrator(10, "");
    public ATM validar_atm(int id)
    {
        foreach (ATM atm in adm.atms)
        {
            if (atm.getId() == id)
            {
                return atm;
            }

        }
        return null;

    }
}