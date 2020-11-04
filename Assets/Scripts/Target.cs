using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        PlayerController player = GetComponent<PlayerController>();
        if (health <= 0f)
        {
            health = 50f;
            player.Die();
            
        }
    }

  
   
}
