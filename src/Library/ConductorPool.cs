using System;
using System.Collections.Generic;
namespace Ridesharing;

public class ConductorPool : IConductor
{
    public int CantidadPasajeros {get; set;}
    public string Type {get; set;}
    public ConductorPool(int cantidad)
    {
        this.CantidadPasajeros = cantidad;
        this.Type = "Pool";
    }
}