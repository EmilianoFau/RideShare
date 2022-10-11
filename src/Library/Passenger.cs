using System;
using System.Collections.Generic;
namespace Ridesharing;

public class Passenger : Users
{
    public Passenger(string name, string surname, int id) : base (name, surname, id)
    {

    }
    public override string Descripcion()
    {
        return $"Nombre: {Name}\nApellido: {Surname}\nPasajero";
    }
}