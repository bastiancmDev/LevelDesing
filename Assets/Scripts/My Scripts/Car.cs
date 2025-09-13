using NUnit.Framework;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Car 
{
    private string marca;
    private int[] Color;
    private int Motor;


    public Car(string marca, int[] color, int motor) {
        this.marca = marca;
        Color = color;
        Motor = motor;
    }

    public bool EsCamion()
    {
        if (Motor > 2000) {
            return true;
        }
        else
        {
            return false;
        }
    }



}

public class Persona
{
    public string Nombre;
    private List<Car> miscarros;


    Persona(Car primerCarro)
    {
        miscarros = new List<Car>();
        miscarros.Add(primerCarro);
    }
}
