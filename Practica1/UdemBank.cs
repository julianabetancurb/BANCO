using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class UdemBank
{
    int balance_banco = 100000000;
    Administrator administrator = new Administrator(10000000, "password");
    ManejoAdmin manejoAdmin = new ManejoAdmin();
    ManejoCliente manejocliente = new ManejoCliente();
    public int getBalancebanco()
    {
        return balance_banco;
    }
    public UdemBank() { }
    public string menu()
    {
        bool salir = false;
        while (salir)
        {
            try
            {
                Console.WriteLine("\n Bienvenidos al banco UdeM");
                Console.WriteLine("Por favor ingrese su usuario:");
                Console.WriteLine("1. Cliente");
                Console.WriteLine("2. Administrador");
                Console.WriteLine("3. Salir");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("cliente, elija una opcion:  " +
                        "\n 1. retirar dinero desde ATM" +
                        "\n 2. depositar dinero desde ATM" +
                        "\n 3. transferir dinero a cliente" +
                        "\n 4. retirar dinero desde sucursal virtual" +
                        "\n 5. depositar dinero desde sucursal virtual ");
                        string respuesta = Console.ReadLine();
                        manejocliente.Manejocliente(respuesta);
                        break;

                    case 2:
                        Console.WriteLine("administrador, elija una opcion:  " +
                        "\n 1. crear cliente" +
                        "\n 2. modificar cliente" +
                        "\n 3. eliminar cliente" +
                        "\n 4. crear atm");
                        string respuesta1 = Console.ReadLine();
                        manejoAdmin.Manejoadmin(respuesta1);
                        break;
                    case 3:
                        salir = true;
                        break;
                }
            }
            catch (OpcionIncorrectaException)
            {
                Console.WriteLine("Opcion incorrecta");
            }
        }
    }
}
        
    
        
     
   

