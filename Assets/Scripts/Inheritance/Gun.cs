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

public class Gun : Weapon
{
    public Gun() : base() //Base means this is a base class
    {
        base.WeaponName = "TommyGun"; //Makes the TommyGun name acive in the editors
        WeaponStrength = 700;
    }

    public Gun(string wName) //Different constructior
    {
        WeaponName =  wName;
        WeaponStrength += 10;
    }
}
