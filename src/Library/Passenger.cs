using System;
using System.Collections.Generic;
using CognitiveCoreUCU;
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
    public override void FoundFace(CognitiveFace cog)
    {
        if (cog.FaceFound)
        {
            this.Face = true;
        }
        else
        {
            this.Face = false;
        }
    }
}
