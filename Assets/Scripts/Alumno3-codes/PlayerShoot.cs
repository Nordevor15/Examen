using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform fire;
    public GameObject bullet;
    public float bulletForce = 20f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bu = Instantiate(bullet, fire.position, fire.rotation);
        Rigidbody2D rb = bu.GetComponent<Rigidbody2D>();
        rb.AddForce(fire.up * bulletForce, ForceMode2D.Impulse);
    }
}
