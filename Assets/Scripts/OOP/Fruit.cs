/*****************************************************************************
// File Name :         Fruit.cs
// Author :            Amber C. Cardamone
// Creation Date :     January 24th, 2024
//
// Brief Description : Fruiiiit.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Fruit
{
    public string name;
    public float weight;
    public Color color;

    public Fruit(string name, Color c, float w) //Consructor that holds 3 variables
    {//Calls the three variables from above
        this.name = name;
        weight = w;
        color = c;
    }
    public Fruit() //Creates a fruit of this type when the parameters don't call for anything
    {
        name = "grape";
        color = Color.yellow;
        weight = 1.0f;
    }
    public Fruit(string n) //makes it so variables that only call the string will make it grab this
    {
        name = n;
        color = Color.green;
        weight = 1.3f;
    }
    public Fruit(Color c) //makes it so variables that only call the Color will make it grab this
    {
        color = c;
        name = "watermelon";
        weight = 5.8f;

        
        //print is a function in monobehavior, so it cant be used for testing in a script like this
    }

    ~Fruit()
    {
        name = null;
        color = Color.clear;
        weight = 0.0f;
    }
}
