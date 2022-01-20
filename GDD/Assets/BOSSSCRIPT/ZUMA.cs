using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZUMA : MonoBehaviour
{
    Image healthc;
    float maxHealth = 100f;
    public static float health;
    // Start is called before the first frame update
    void Start()
    {
        healthc = GetComponent<Image>();
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthc.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            makeDead();
        }
    }
    void makeDead()
    {
        Destroy(gameObject);
    }
}