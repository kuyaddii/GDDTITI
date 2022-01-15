using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public int health = 500;
	public Animator animator;

	private void Start()
	{
		
		animator = GetComponent<Animator>();
		//DontDestroyOnLoad (gameObject);
	}

	public GameObject deathEffect;
	public GameObject RageEffect;


	public void TakeDamage(int damage)
	{
		health -= damage;
		if (health <= 550)
		{
			animator.SetTrigger("MATTCK");

		}

		if (health <= 300)
		{
			animator.SetTrigger("Attack");
			
		}
		if (health <= 200)
		{
			Rage();
		}
		//if (health <= 25)
		///{
		//	animator.SetTrigger("rage"); ;
		//}

		if (health <= 0)
		{
			Die();
		}
	}

	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
	void Rage()
	{
		Instantiate(RageEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}