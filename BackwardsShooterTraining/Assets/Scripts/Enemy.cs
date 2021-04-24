using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Here designer can change that object the enemy follows
    //Speed,health and how much damage enemies take from a single bullet can be changed at the inspector.

    public Transform followThis;
    private Rigidbody rb;
    public float speed = 4f;
    public float health = 150f;
    public float damageTakenByHit = 50f;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (followThis != null)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, followThis.position, speed * Time.fixedDeltaTime);
            rb.MovePosition(pos);
            transform.LookAt(followThis);
        }
        else
        {
            anim.SetBool("isDead", true);
        }

    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Bullet")
        {
            health -= damageTakenByHit;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }

    }
}
