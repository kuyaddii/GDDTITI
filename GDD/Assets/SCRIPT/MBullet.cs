using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MBullet : MonoBehaviour
{
	Image zhealthbbar;
	Image bhealthbar;
	public float speed = 40f;
	public int damage = 40;
	public Rigidbody2D rb;
	public GameObject impactEffect;

	// Use this for initialization
	void Start()
	{
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D(Collider2D hitInfo)
	{
		if (hitInfo.tag == "Enemy")
		{
			ZUMA.Zhealth -= damage;
		}
		if (hitInfo.tag == "Enemy")
		{
			BAkunawa.Bhealth -= damage;
		}
		if (hitInfo.tag == "Enemy")
		{
			dragon.Dhealth -= damage;
		}
		if (hitInfo.tag == "Enemy")
		{
			main.Mhealth -= damage;
		}
		if (hitInfo.tag == "Player")
		{
			healthbarscript.health -= damage;
		}
		Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}

}