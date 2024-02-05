/*****************************************************************************
// File Name :         FruitManager.cs
// Author :            Amber C. Cardamone
// Creation Date :     January 24th, 2024
//
// Brief Description : Manage the fruit.
*****************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public List<Fruit> fruitSalad; //Makes a list
    // Start is called before the first frame update
    void Start()
    {
        fruitSalad = new List<Fruit>(); //Defining fruit salad from the Fruit script

        Fruit apple = new Fruit("apple", Color.blue, 2.1f); //Created an instance of the class Fruit, gave it a name, 
                                                            //weight, and color

        CreateFruitSalad();
        fruitSalad.Add(apple);
        DisplayFruitSalad();
    }

    private void DisplayFruitSalad()
    {
        for(int i = 0; i < fruitSalad.Count; i++) //For loop to go through arrays and lists, i is basic counter
        {
            print(fruitSalad[i].color.ToString() + " " + fruitSalad[i].name + " weighing " + fruitSalad[i].weight + 
            " units."); // This all grabs the different components we have gathered (color, name, and weight, and is
            // printing them in the console
        }
    }

    private void CreateFruitSalad() 
    {
        
        fruitSalad.Add(new Fruit()); //Grabs a fruit that is not defined, so goes to Grape automatically
        fruitSalad.Add(new Fruit("Strawberry")); //Grabs a fruit that is only defined by its name, one parameter
        fruitSalad.Add(new Fruit(Color.red));
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
