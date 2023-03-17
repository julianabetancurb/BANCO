using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
public class Administrator : User //clase hija
{
    public List<Client> clients = new List<Client>();
    public List<ATM> atms = new List<ATM>();
    ATM atm; 

    public Administrator(int id, string password) : base(id, password) { }
  
    
    public void add_client(int id, string password, string type_client) //CREAR CLIENTE
    {
     
        Client client = new Client(id, password, type_client);
        clients.Add(client);
        write_txt();

    }
    public void delete_client(int id) //ELIMINAR CLIENTE
    {
        foreach (Client c in clients)
        {
            if (c.getId() == id)
            {
                clients.Remove(c);
                write_txt();

            }
            else { throw new Exception("Usuario no encontrado"); }
        }
    }
    public void modify_client(int id) //MODIFICAR CLIENTE
    {
        foreach (Client c in clients)
        {
            if (c.getId() == id)
            {
                Console.WriteLine("Ingrese el nuevo id");
                int newId = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nuevo tipo de cliente (regular - platino");
                string newTypeclient = (Console.ReadLine());
                c.setId(newId);
                c.setTypeClient(newTypeclient);
                write_txt();
            }
        }

    }
    public void add_atm(int id, int balance_atm)//CREAR ATM
    {
        ATM atm = new ATM(id, balance_atm);
        atms.Add(atm);
        
    }
 
    public string getAccountNumber() //CREAR NUMERO DE CUENTA
    {
        Random rand = new Random();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10; i++)
        {
            sb.Append(rand.Next(10));
        }
        string numeroAleatorio = sb.ToString();
        return numeroAleatorio;
    }
    public string toString()
    {
        return "Número de cuenta: " + this.getAccountNumber();

    }
    public bool validar_id(Client client) 
    {
        bool Validar = true;
        int id = client.Id;
        foreach (Client client1 in clients) 
        {
            if (id == client1.Id)
            {
                return true;
            }
            else return false;           
        }
        return Validar = false;
    }
    public void write_txt() //CREAR TXT 
    {
        TextWriter textWriter = new StreamWriter("C:\\Users\\DIANA\\Downloads\\practica1.txt");
        foreach (Client client in clients)
        {
            textWriter.Write(client.ToString());
            textWriter.WriteLine(client);

        }
        textWriter.Close();
    }
    public void read_txt() //LEER TXT
    {
        List<string> lines = File.ReadAllLines("C:\\Users\\DIANA\\Downloads\\practica1.txt").ToList();
        
        foreach (var line in lines)
        {
            string[] parts = line.Split("\n");

            int id = int.Parse(parts[0]);
            string password = parts[1];
            string type_client = parts[2];

            Client client = new Client(id, password, type_client);

            clients.Add(client);
        }
    }
    

}
    

