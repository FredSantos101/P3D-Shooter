using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBoxController : MonoBehaviour {
    public GameObject box;

    private int numberBullets;
    private Vector3 rotate;



	// Use this for initialization
	void Start () {
        numberBullets = 15;
	}
	
	// Update is called once per frame
	void Update () {
        box.transform.Rotate(0, Time.deltaTime * 5, 0);
	}

	private void OnTriggerEnter(Collider other)
	{
        if( other.CompareTag("Player")){
            other.GetComponent<WeaponControler>().addBullets(numberBullets);
        }
	}
}
