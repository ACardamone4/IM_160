using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private string PlayerName;
    [SerializeField] private int PlayerHealth;
    [SerializeField] private int PlayerDamage;
    [SerializeField] private float PlayerSpeed;

    public string PlayerName1 { get => PlayerName; set => PlayerName = value; }
    public int PlayerHealth1 { get => PlayerHealth; set => PlayerHealth = value; }
    public int PlayerDamage1 { get => PlayerDamage; set => PlayerDamage = value; }
    public float PlayerSpeed1 { get => PlayerSpeed; set => PlayerSpeed = value; }
}
