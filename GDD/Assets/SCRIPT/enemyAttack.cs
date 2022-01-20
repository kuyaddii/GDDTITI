using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
	public float attack1Damage;
	[SerializeField] Transform spawnPoint;
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
		{
			healthbarscript.health -= attack1Damage;
			//	ScoreScript.curscore += 1;
			if (healthbarscript.health == 0)
			{
				col.transform.position = spawnPoint.position;
			}
		}
	}
}