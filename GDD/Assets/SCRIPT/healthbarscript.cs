using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarscript : MonoBehaviour
{
    Image healthBar;
    float maxHealth = 500f;
    public static float health;
    public GameObject kdeie;
    public GameObject RECALL;
    public Transform RespawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            MAKEDEAD();
        }
    }
    void MAKEDEAD()
    {
        Destroy(kdeie);
     
    }
}
