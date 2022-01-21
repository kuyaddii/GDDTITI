using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootBAKU : MonoBehaviour
{
    public float speed = 40f;
    public int damage = 40;
    public Rigidbody2D rb;
    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.left * speed;
    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Player")
        {
            healthbarscript.health -= damage;
        }
    }
}
