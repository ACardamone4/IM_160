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

public class Weapon : MonoBehaviour
{
    private string weaponName;
    private int weaponStrength;

    protected int WeaponStrength { get => weaponStrength; set => weaponStrength = value; }
    protected string WeaponName { get => weaponName; set => weaponName = value; }

    protected virtual void UseWeapon(int damage)
    {
        WeaponStrength -= damage; //weaponStrength = weaponStrength - damage //Makes the weaponStrength lose damage
                                  //when you use the weapon
    }
}
