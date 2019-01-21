using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject projectile1;
    public GameObject nextProjectileUI;

    private Color color;

    private void Start()
    {   
        color = new Color();
        UnityEngine.Color  randomColor = color.GetRandomColor();
        projectile1.GetComponent<SpriteRenderer>().color = randomColor;
        nextProjectileUI.GetComponent<SpriteRenderer>().color = randomColor;
    }

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
        Instantiate(projectile1, firePoint.position, firePoint.rotation);
        UnityEngine.Color randomColor = color.GetRandomColor();
        projectile1.GetComponent<SpriteRenderer>().color = randomColor;
        nextProjectileUI.GetComponent<SpriteRenderer>().color = randomColor;
    }
}
