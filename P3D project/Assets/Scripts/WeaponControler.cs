using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControler : MonoBehaviour {

    private int numberBullets;
    private int maxNumberBullets;
    private bool hasBullets;

    private bool canShoot = true;
    public float shootCooldown;
    private float shootTimeRemaining;


    public GameObject bullet;


	// Use this for initialization
	void Start () {
        maxNumberBullets = 150;
        numberBullets = 50;
        canShoot = true;
	}

    private void ShootProjectile()
    {
        if (canShoot)
        {


            var ray = GameObject.Find("Main Camera").GetComponent<Camera>().ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0));
            bullet.GetComponent<ProjectileControler>().direction = ray.direction;
            bullet.GetComponent<ProjectileControler>().direction.Normalize();
            
           
            Instantiate(bullet, this.transform.position, Quaternion.identity);
            canShoot = false;
            shootTimeRemaining = shootCooldown;
            numberBullets --;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (numberBullets > 0) hasBullets = true;
        else hasBullets = false;

        if (hasBullets)
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

            if (Input.GetMouseButtonDown(0))
            {
                ShootProjectile();
            }
        }
	}

    public void addBullets(int bullets){
        numberBullets += bullets;
        numberBullets = Mathf.Clamp(numberBullets, 0, 250);
    }

	
       

}
