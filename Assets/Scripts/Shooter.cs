using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform firePoint;
    public List<GameObject> projectiles_list = new List<GameObject>();
    public GameObject projectile1;
    public GameObject projectile2;
    public GameObject projectile3;

    private void Start()
    {
        projectiles_list.Add(projectile1);
        projectiles_list.Add(projectile2);
        projectiles_list.Add(projectile3);
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
        int projectile_index = Random.Range(0, 3);
        Instantiate(projectiles_list[projectile_index], firePoint.position, firePoint.rotation);
    }
}
