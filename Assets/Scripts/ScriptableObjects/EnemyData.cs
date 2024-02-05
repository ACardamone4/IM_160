using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Makes an asset menu, which can be used to affect variables
[CreateAssetMenu(fileName = "EnemyData", menuName = "Enemy Data")] 
public class EnemyData : ScriptableObject //Inherits from ScriptableObject
{
    [SerializeField] private string EnemyName;
    [SerializeField] private string EnemyDescription;
    [SerializeField] private int EnemyHealth;
    [SerializeField] private int EnemyDamage;
    [SerializeField] private float EnemySpeed;

    //Right click, press quick actions, and press the encapsulate to get get/set 
    public string EnemyName1 { get => EnemyName; set => EnemyName = value; }
    public string EnemyDescription1 { get => EnemyDescription; set => EnemyDescription = value; }
    public int EnemyHealth1 { get => EnemyHealth; set => EnemyHealth = value; }
    public int EnemyDamage1 { get => EnemyDamage; set => EnemyDamage = value; }
    public float EnemySpeed1 { get => EnemySpeed; set => EnemySpeed = value; }

    public void Attacked(int damage)
    {
        EnemyHealth1 -= damage;

        //Debug log is necessary since it isn't a MonoBehavior
        Debug.Log("I have taken " + damage + " damage! OW! I have " + EnemyHealth1 + " Health Left!"); 
    }
    
}
