using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;
    
    [HideInInspector]
    public int playerHealth;
    
    
    public void Start()
    {
        GM = this;
    }
    
    
    
    
}