using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBossScript : MonoBehaviour
{

	public int health = 1000;
	public Animator animator;

	private void Start()
	{

		animator = GetComponent<Animator>();

		//DontDestroyOnLoad(gameObject);
	}

	public GameObject deathEffect;

	public void TakeDamage(int damage)
	{
		health -= damage;

		if (health <= 1000)
		{
			animator.SetTrigger("MATTCK");

		}

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


}