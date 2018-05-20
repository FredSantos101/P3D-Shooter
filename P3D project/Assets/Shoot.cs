using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    private bool hasBullets;

    private bool canShoot;
    public float shootCooldown;
    private float shootTimeRemaining;

    public GameObject bullet;

	// Use this for initialization
	void Start () {
        canShoot = true;
	}
	
    private void ShootProjectile()
    {


            Instantiate(bullet, this.transform.position, Quaternion.identity);
            canShoot = false;
            shootTimeRemaining = shootCooldown;

    }

    // Update is called once per frame
    void Update()
    {
       
            if (!canShoot)
            {
                if (shootTimeRemaining <= 0)
                {
                    canShoot = true;
                }
                else
                {
                    shootTimeRemaining -= Time.deltaTime;
                }
            }

        else ShootProjectile();
    }
}
