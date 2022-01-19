using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dboss : MonoBehaviour
{

    public int health;
    public int damage;
   // private float timeBtwDamage = 1.5f;


   // public Animator camAnim;
    //public Slider healthBar;
    private Animator anim;
    //public bool isDead;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public GameObject deathEffect;
    private void Update()
    {

        if (health <= 900)
        {
            anim.SetTrigger("DATTCK");
        }

        if (health <= 0)
        {
            Die();
        }
        void Die()
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        // give the player some time to recover before taking more damage !
       // if (timeBtwDamage > 0)
        {
       //     timeBtwDamage -= Time.deltaTime;
        }

        //healthBar.value = health;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // deal the player damage ! 
      //  if (other.CompareTag("Player") && isDead == false)
        {
           // if (timeBtwDamage <= 0)
            {
              //  camAnim.SetTrigger("shake");
            //    other.GetComponent<Player>().health -= damage;
            }
        }
    }
}