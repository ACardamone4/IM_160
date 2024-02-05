/*****************************************************************************
// File Name :         Weapon.cs
// Author :            Amber C. Cardamone
// Creation Date :     January 31st, 2024
//
// Brief Description : 
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Gun tommyGun; //Takes a variable from Gun
    private Gun revolver;

    // Start is called before the first frame update
    void Start()
    {
        tommyGun = new Gun(); //References the Gun script
        revolver = new Gun("Revolver"); //Able to manipulate and change the name of a gun using the base class
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
