using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour {

    private int hp;
    private int points;
    private bool canShoot;


    // Use this for initialization
    void Start()
    {
        hp = 100;
        points = 25;
    }
	
	// Update is called once per frame
	void Update () {

        if (hp <= 0)
        {
            GameObject.Find("Player").GetComponent<GameControler>().addPoints(points);
            Destroy(gameObject);
        }
		
	}

	private void OnTriggerStay(Collider other)
	{
        if( other.CompareTag("Player")){

            canShoot = true;
            
        }
	
	}
	private void OnTriggerExit(Collider other)
	{
        if(other.CompareTag("Player")){
            canShoot = false;
        }
	}

    public void damage(int i){
        hp -= i;
    }


}
