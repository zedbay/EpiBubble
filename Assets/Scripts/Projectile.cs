using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 300F;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;

    }
    
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.name == "DirtTop" || hitInfo.name == "BubbleBase(Clone)" || hitInfo.name == "BubbleProjectile(Clone)")
        {
            rb.velocity = transform.right * 0;
            rb.isKinematic = true;
        } 
    }
}
