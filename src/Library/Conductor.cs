using System;
using System.Collections.Generic;
using CognitiveCoreUCU;
namespace Ridesharing;

public class Conductor : Users
{
    public string Vehicle {get; set;}
    public string Bio {get; set;}
    public IConductor Type {get; set;}
    public Conductor(string vehicle, string bio, string name, string surname, int id, int cantidad) : base (name, surname, id) 
    {
        this.Vehicle = vehicle;
        this.Bio = bio;
        if (cantidad == 1)
        {
            this.Type = new ConductorComuun();
        }
        else if (cantidad > 1)
        {
            this.Type = new ConductorPool(cantidad);
        }
    }
    public override string Descripcion()
    {
        return $"Nombre: {Name}\nApellido: {Surname}\nVehículo: {Vehicle}\nBiografía: {Bio}\nTipo: {Type.Type}";
    }

    public override void FoundFace(CognitiveFace cog)
    {
        if (cog.FaceFound)
        {
            if (cog.SmileFound)
            {
                this.Face = true;
            }
        else
        {
            this.Face = false;
        }
        }
    }
}

