using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ManejoAdmin
{
    Administrator administrator = new Administrator(1000, "PASS");
    UdemBank banco;
    public void Manejoadmin(string respuesta1)
    {
        
        //crear cliente
        if (respuesta1 == "1")
        {
            Console.WriteLine("Ingrese el id del cliente");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("escriba la contraseña");
            string password = Console.ReadLine();
            Console.WriteLine("Ingrese el tipo de cliente");
            string type_client = Console.ReadLine();
            administrator.add_client(id, password, type_client);
            string cuentanum = administrator.getAccountNumber();
            Console.WriteLine("el numero de cuenta del nuevo cliente será" + cuentanum);
        }
        else
        {
            if (respuesta1 == "2") //modificar cliente
            {
                Console.WriteLine("Ingrese el nuevo id");
                int newid = int.Parse(Console.ReadLine());

                administrator.modify_client(newid);
            }
            else
            {
                if (respuesta1 == "3") //eliminarcliente
                {
                    Console.WriteLine("ingrese el id del cliente a eliminar");
                    int delid = int.Parse(Console.ReadLine());

                    administrator.delete_client(delid);
                }
                else
                {
                    if (respuesta1 == "4") //crear-añadir atm nuevo
                    {
                        Console.WriteLine("ingrese el num del atm");
                        int ideatm = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el balance del atm");
                        int balanceatm = int.Parse(Console.ReadLine());
                        if (balanceatm < banco.getBalancebanco())
                        {
                            administrator.add_atm(ideatm, balanceatm);
                        }
                        else
                        {
                            Console.WriteLine("El balance que le desea asignar al atm sobrepasa el balance del banco");
                        }
                        

                    }
                    else
                    {
                        throw new OpcionIncorrectaException("Opcion invalida");

                    }
                }
            }
        }




    }
       
}
