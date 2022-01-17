using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
	public float attack1Damage;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
		{
			//healthbarscript.health -= attack1Damage;
			
		}
	}

}
