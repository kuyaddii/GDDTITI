using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BAkunawa : MonoBehaviour
{
    Image bhealthbar;
    float maxHealth = 700f;
    public static float Bhealth;
    public Animator animator;
    public GameObject bkilled;
    // Start is called before the first frame update
    void Start()
    {
        bhealthbar = GetComponent<Image>();
        Bhealth = maxHealth;
        animator = GetComponent<Animator>();
    }
    public GameObject deathEffect;
    public void TakeDamage(int damage)
    {
        Bhealth -= damage;

        if (Bhealth <= 500)
        {
            animator.SetTrigger("DATTCK");

        }
    }

    // Update is called once per frame
    void Update()
    {

        bhealthbar.fillAmount = Bhealth / maxHealth;
        if (bhealthbar.fillAmount == 0)
        {
            DEAD();
        }
    }
    void DEAD()
    {
        Destroy(bkilled);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
    }

}
