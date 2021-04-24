using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    
    //If wanted, firePoint can be changed on the inspector, can be a guns muzzle for example.
    //Also projectilePrefab can be changed to use something else for a bullet.
    public Transform firePoint;
    public GameObject projectilePrefab;

    public float shootDelay;
    private float projectileForce = 0.2f;
    float elapsed = 0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        elapsed += Time.deltaTime;
        if(elapsed >= shootDelay)
        {
            elapsed = elapsed % shootDelay;
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.up * projectileForce, ForceMode.Impulse);
    }
    
    
}
