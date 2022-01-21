using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main : MonoBehaviour
{
    Image mainan;
    float maxHealth = 1500f;
    public static float Mhealth;
    public Animator animator;
    public GameObject kdeie;
    // Start is called before the first frame update
    void Start()
    {
        mainan = GetComponent<Image>();
        Mhealth = maxHealth;
        animator = GetComponent<Animator>();
    }
    public GameObject deathEffect;
    public void TakeDamage(int damage)
    {
        Mhealth -= damage;

        if (Mhealth <= 1500)
        {
            animator.SetTrigger("MATTCK");

        }
    }

    // Update is called once per frame
    void Update()
    {

        mainan.fillAmount = Mhealth / maxHealth;
        if (mainan.fillAmount == 0)
        {
            DEAD();
        }
    }
    void DEAD()
    {
        Destroy(kdeie);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
    }

}
