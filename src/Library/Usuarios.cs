using System;
using System.Collections.Generic;
namespace Ridesharing;

public class Usuario
{
    public Usuario(string name, string surname, int id)
    {
        this.Name = Name;
        this.Surname = surname;
        this.ID = id;
    }
    public string Name {get; set;}
    public string Surname {get; set;}
    public int ID {get; set;}
    public List<double> Califications = new List<double>();

}