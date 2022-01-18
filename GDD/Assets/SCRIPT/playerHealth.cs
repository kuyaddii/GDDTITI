using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{

	public float playerMaxHealth;
	public float pcurrentHealth;
	float edamage;

	// Use this for initialization
	void Start()
	{
		pcurrentHealth = playerMaxHealth;

	}

	// Update is called once per frame
	void Update()
	{

	}
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "enemy")
		{
			enemyAttack attackdamage = col.gameObject.GetComponent<enemyAttack>();
			edamage = attackdamage.attack1Damage;
			pcurrentHealth -= edamage;
			Debug.Log(edamage);
			if (pcurrentHealth <= 0)
			{
				makeDead();
			}
		}
	}

	void makeDead()
	{
		Destroy(gameObject);
	}
}