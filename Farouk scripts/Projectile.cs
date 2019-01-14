﻿using System.Collections;
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
        Debug.Log(hitInfo.name);
        if(hitInfo.name == "BackWallTrigger" || hitInfo.name == "Projectile(Clone)")
        {
            rb.velocity = transform.right * 0;
            rb.isKinematic = true;
        }
        if(hitInfo.name == "WallTrigger")
        {
            Debug.Log("side wall");            
        }
    }
}
