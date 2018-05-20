using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    public int bulletDamage;
    private float lifeTime;
    private int movSpeed;

    public Vector3 direction;

    public GameObject bullet;

    // Use this for initialization
    void Start()
    {
        //bulletRgdBody = bullet.GetComponent<Rigidbody>();
        movSpeed = 50;
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime += Time.deltaTime;
        if (lifeTime >= 5)
        {
            Destroy(gameObject);
        }
        this.transform.Translate(direction * Time.deltaTime * movSpeed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Terrain"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<EnemyControler>().damage(bulletDamage);
            print("ola");
            Destroy(gameObject);
        }
    }
}