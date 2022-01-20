using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BAKUNAWAENEMY : MonoBehaviour
{
	public int health = 700;
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

		if (health <= 700)
		{
			animator.SetTrigger("DATTCK");
		}

		if (health <= 0)
		{
			Die();
		}
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("FIRE"))
		{
			animator.SetTrigger("DATTCK");
		}



	}
	void Die()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
}