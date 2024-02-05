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

public class Knife : Weapon //Makes this script reference from the Weapon
{
    protected override void UseWeapon(int damage) //Allows us to take a class from another script
    {
        base.UseWeapon(damage * 2); //Makes the knife take double damage when used
    }
}
