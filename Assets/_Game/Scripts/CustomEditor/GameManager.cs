using System;
using System.Collections;
using System.Collections.Generic;
using Ship;
using UnityEditor;
using UnityEngine;
using Variables;
[CreateAssetMenu(menuName = "Gabriel/Game Manager")]
public class GameManager : ScriptableObject
{
    
    //Health
    public int playerHealth;
    public bool colActive;
    //public PolygonCollider2D collision;

    //Ship Engine
    public float throttlePower;
    public float rotationPower;
    
    
    //Asteroids
    public int spawnTime;
    public int spawnAmount;
    

    public void Update()
    {
        
    }

   /* void CollisionsActive()
    {
        collision.enabled = colActive;
    }*/


    public void ResetDefault()
    {
        Debug.Log("Button");

        playerHealth = 10;
        colActive = true;
        throttlePower = 7;
        rotationPower = 3;
        spawnTime = 4;
        spawnAmount = 2;

    }
    
    
}
