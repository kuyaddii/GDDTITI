using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dragon : MonoBehaviour
{
    Image ddragon;
    float maxHealth = 900f;
    public static float Dhealth;
    public Animator animator;
    public GameObject kdeie;
    // Start is called before the first frame update
    void Start()
    {
        ddragon = GetComponent<Image>();
        Dhealth = maxHealth;
        animator = GetComponent<Animator>();
    }
    public GameObject deathEffect;
    public void TakeDamage(int damage)
    {
        Dhealth -= damage;

        if (Dhealth <= 900)
        {
            animator.SetTrigger("mini");

        }
    }

    // Update is called once per frame
    void Update()
    {

        ddragon.fillAmount = Dhealth / maxHealth;
        if (ddragon.fillAmount == 0)
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
