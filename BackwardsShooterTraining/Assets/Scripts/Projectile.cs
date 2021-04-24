using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo)
    {
        //Destroys the bullets when they touch an enemy, an obstacle or the invisible barrier at the start, behind the enemy line.
        if (collisionInfo.collider.tag == "Enemy" || collisionInfo.collider.tag=="obstacle" || collisionInfo.collider.tag=="Bullet")
        {
            Destroy(gameObject);
        }
    }
}
