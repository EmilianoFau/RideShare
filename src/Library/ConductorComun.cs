using System;
using System.Collections.Generic;
namespace Ridesharing;

public class ConductorComuun : IConductor
{
    public int CantidadPasajeros {get; set;}
    public string Type {get; set;}
    public ConductorComuun()
    {
        this.CantidadPasajeros = 1;
        this.Type = "Comun";
    }
}