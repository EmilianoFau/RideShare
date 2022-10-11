using System;
using System.Collections;
using Ridesharing;
using CognitiveCoreUCU;
using TwitterUCU;
using System.Drawing;
namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!*/

            Users pasajero1 = new Passenger("Juan", "Bautista", 11155544);
            Users pasajero2 = new Passenger("Agustin", "Agus", 22555666);
            Users pasajero3 = new Passenger("Jesus","Loren", 33226655);
            Users conductor1 = new Conductor("Lopus", "adios", "Felipe", "Santera", 22335566, 1);
            Users conductor2 = new Conductor("Sepul", "hola", "Lorenzo", "Perez", 88996655, 3);
            Rideshare viaje = new Rideshare();
            
            viaje.Add(conductor1,@"bill2.jpg");
            viaje.Add(conductor2,@"seria.jpg");
            viaje.Add(pasajero1,@"bill2.jpg");
            viaje.Add(pasajero2,@"prueba.jpg");
            viaje.Add(pasajero3,@"seria.jpg");

            pasajero1.Qualify(1,"Se");
            pasajero1.Qualify(5,"Se2");
            var cali = pasajero1.CalculoCalificacion();
            Console.WriteLine(cali);
        }
    }
}

