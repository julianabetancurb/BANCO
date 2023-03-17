using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ManejoCliente
{
    
    Administrator administrator = new Administrator(100, "");
   
    Validar validar = new Validar();
    ATM atm;
    SucursalVirtual sucursal;
    Client client;

    public void Manejocliente(string respuesta )
    {
        

        if (respuesta == "1") 
        {
            Console.WriteLine("Elija el atm desde el que desea retirar (ingrese num atm)");
            foreach (var at in administrator.atms)
            {
                Console.WriteLine($"{at.Id}, {at.Balance}");
            }
            int atmelegido = int.Parse(Console.ReadLine());
            validar.validar_atm(atmelegido);

            Console.WriteLine("tipo cliente: 1. regular o 2. platino");
            string tipo_cliente = Console.ReadLine();
            Console.WriteLine("Cuanto dinero desea retirar en el atm elegido?");
            int dinero = int.Parse(Console.ReadLine());
            if (dinero > client.getBalance() || dinero < 0)
            {
                Console.WriteLine("La cantidad a retirar sobrepasa su saldo");
            }
            else 
            {
                if (tipo_cliente == "1")
                {
                    client.withdraw_regular(dinero);
                    atm.upgrade_balance_atm(dinero);
                    
                }
                else
                {
                    if (tipo_cliente == "2")
                    {
                        client.withdraw_platium(dinero);
                        atm.upgrade_balance_atm(dinero);
                    }
                    else throw new OpcionIncorrectaException("Ingreso una opcion incorrecta");
                    
                }
            }                                         
        }
        else
        {
            if (respuesta == "2")
            {
                Console.WriteLine("Cuanto dinero desea depositar por atm?");
                int money = int.Parse(Console.ReadLine());
                client.deposit(money);
                Console.WriteLine("Su nuevo balance es de" + client.getBalance());
            }
            else
            {
                if (respuesta == "3")
                {
                    Console.WriteLine("Cuanto dinero desea tranferir?");
                    int tmoney = int.Parse(Console.ReadLine());                                 
                    client.transfer(tmoney);
                    Console.WriteLine("Su nuevo balance es de" + client.getBalance());

                }
                else
                {
                    if (respuesta == "4")
                    {
                        Console.WriteLine("Cuanto dinero desea retirar en la sucursal?");
                        int dinerovirtual = int.Parse(Console.ReadLine());
                        sucursal.virtual_withdraw(dinerovirtual);
                        atm.upgrade_balance_atm(dinerovirtual);
                       
                    }
                    else
                    {
                        if (respuesta == "5")
                        {
                            Console.WriteLine("cuanto dinero desea depositar en la sucursal?");
                            int dinerodepositar = int.Parse(Console.ReadLine());
                            sucursal.virtualdeposit(dinerodepositar);
                            atm.uptade_balance_atm(dinerodepositar);
                            
                        }
                        else throw new OpcionIncorrectaException("Opcion invalida");
                    }
                }
                
            }
        }

    }
}
