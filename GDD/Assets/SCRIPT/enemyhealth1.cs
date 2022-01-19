using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth1 : MonoBehaviour
{

	public float enemyMaxHealth;
	public float currentHealth;
	public Animator animator;

	// Use this for initialization
	void Start()
	{
		currentHealth = enemyMaxHealth;
		animator = GetComponent<Animator>();


	}
	public GameObject deathEffect;
	public void TakeDamage(int damage)
	{
		currentHealth -= damage;
		if (currentHealth <= 700)
		{
			animator.SetTrigger("DATTCK");

		}
		if (currentHealth <= 0)
		{
			makeDead();
		}
	}
	void makeDead()
	{
		Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

}