using System;
using UnityEngine;

namespace Ship
{
    public class Health : MonoBehaviour
    {
        private int _health = 10;
        
        private const int MIN_HEALTH = 0;

        private void Update()
        {
            _health = GameManager.GM.playerHealth;
        }

        public void TakeDamage(int damage)
        { 
            Debug.Log("Took some damage");
            GameManager.GM.playerHealth = Mathf.Max(MIN_HEALTH, _health - damage);
        }
    }
}
