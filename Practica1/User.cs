using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class User //clase padre
{
    public int Id; 
    public string Password;


    public User(int id, string password) //constructor
    {
        this.Id = id;
        this.Password = password;
    }
    public int getId() //definicion de setters y getters
    {
       return this.Id; 
    }
    public void setId(int newId)
    {
        this.Id=newId;  
    }
    public string getPassword
    {
        get { return this.Password; }
    }
    public void setPassword(string newPassword)
    {
        this.Password = newPassword;
    }
   
   


}

