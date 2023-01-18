using System;
using System.Collections;
using System.Collections.Generic;
using Ship;
using UnityEditor;
using UnityEngine;
using Variables;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;
    
    //Health
    [HideInInspector]
    public int playerHealth;
    [HideInInspector]
    public Hull hullScript;
    [HideInInspector]
    public bool colActive;
    [HideInInspector] public PolygonCollider2D collision;

    //Ship Engine
    [HideInInspector] public float throttlePower;
    [HideInInspector] public float rotationPower;
    
    
    //Asteroids
    [HideInInspector] public int spawnTime;
    [HideInInspector] public int spawnAmount;
    
    public void Awake()
    {
        GM = this;
        hullScript = FindObjectOfType<Hull>();
        collision = FindObjectOfType<PolygonCollider2D>();
    }

    public void Update()
    {
        CollisionsActive();
    }

    void CollisionsActive()
    {
        collision.enabled = colActive;
    }


    public void ResetDefault()
    {
        playerHealth = 10;
        colActive = true;
        throttlePower = 7;
        rotationPower = 3;
        spawnTime = 4;
        spawnAmount = 2;

    }
    
    
}
