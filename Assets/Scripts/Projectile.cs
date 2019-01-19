using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

    }
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.name == "DirtTop" || hitInfo.name == "red_projectile(Clone)" || hitInfo.name == "blue_projectile(Clone)" || hitInfo.name == "yellow_projectile(Clone)")
        {
            rb.velocity = transform.right * 0;
            rb.isKinematic = true;
        } 
    }
}
