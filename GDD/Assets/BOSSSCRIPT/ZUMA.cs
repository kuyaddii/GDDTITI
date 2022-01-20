using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZUMA : MonoBehaviour
{
    Image zhealthbar;
    float maxHealth = 500f;
    public static float Zhealth;
    public Animator animator;
    public GameObject killed;
    // Start is called before the first frame update
    void Start()
    {
        zhealthbar = GetComponent<Image>();
        Zhealth = maxHealth;
        animator = GetComponent<Animator>();
    }
    public GameObject deathEffect;
    public void TakeDamage(int damage)
    {
        Zhealth -= damage;

        if (Zhealth <= 500)
        {
            animator.SetTrigger("Attack");

        }
    }

    // Update is called once per frame
    void Update()
    {

        zhealthbar.fillAmount = Zhealth / maxHealth;
        if (zhealthbar.fillAmount == 0)
        {
            DEAD();
        }
    }
    void DEAD()
    {
        Destroy(killed);
        Instantiate(deathEffect, transform.position, Quaternion.identity);
    }

}
