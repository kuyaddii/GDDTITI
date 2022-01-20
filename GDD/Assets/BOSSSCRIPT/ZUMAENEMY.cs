using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZUMAENEMY : MonoBehaviour
{
	public int health = 500;
	public Animator animator;

	private void Start()
	{

		animator = GetComponent<Animator>();
		//DontDestroyOnLoad (gameObject);
	}

	public GameObject deathEffect;



	public void TakeDamage(int damage)
	{
		health -= damage;

		if (health <= 500)
		{
			animator.SetTrigger("Attack");

		}
		if (health <= 500)
		{
			animator.SetTrigger("DATTCK");

		}
		if (health <= 500)
		{
			animator.SetTrigger("mini");

		}
		if (health <= 500)
		{
			animator.SetTrigger("MATTCK");

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
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("FIRE"))
		{
			animator.SetTrigger("Attack");
		}


	}
	void Die()
		{
			Instantiate(deathEffect, transform.position, Quaternion.identity);
			Destroy(gameObject);
		}
}