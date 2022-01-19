using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBullet : MonoBehaviour
{

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
		BossHelathbar.health -= damage;

		Enemy enemy = hitInfo.GetComponent<Enemy>();
		if (enemy != null)
		{
			enemy.TakeDamage(damage);
		}
		Dboss dboss = hitInfo.GetComponent<Dboss>();
		if (dboss != null)
		{
			enemy.TakeDamage(damage);
		}
		MainBossScript mainboss = hitInfo.GetComponent<MainBossScript>();
		if (mainboss != null)
		{
			enemy.TakeDamage(damage);
		}
		MiniBossScript miniboss = hitInfo.GetComponent<MiniBossScript>();
		if (miniboss != null)
		{
			enemy.TakeDamage(damage);
		}

		Instantiate(impactEffect, transform.position, transform.rotation);

		Destroy(gameObject);
	}

}