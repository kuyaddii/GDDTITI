using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHelathbar : MonoBehaviour
{
    Image healthBar;
    float maxHealth;
    public static float health;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;

    }

    // Update is called once per frame
    public void TakeDamage(int damage) { 
    
        healthBar.fillAmount = health / maxHealth;
    }
}
