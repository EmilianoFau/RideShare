using System;
using System.Collections.Generic;
namespace Ridesharing;

public class Conductores : Usuario
{
    public string Vehicle {get; set;}
    public string Bio {get; set;}
    public Conductores(string vehicle, string bio) 
    {
        this.Vehicle = vehicle;
        this.Bio = bio;
    }
}