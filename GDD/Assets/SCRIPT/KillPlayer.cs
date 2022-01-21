using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillPlayer : MonoBehaviour
{
	
	[SerializeField] Transform spawnPoint;

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.transform.CompareTag("Player"))
		{
			col.transform.position = spawnPoint.position;
		}
		if (healthbarscript.health == 0)
		{
			col.transform.position = spawnPoint.position;
			
		}
	}
}