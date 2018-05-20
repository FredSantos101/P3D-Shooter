using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour {

    public int points;
    private bool end;
    public int hp;

    // Use this for initialization
    void Start(){
        end = false;
        points = 0;
        hp = 100;
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        if(!end){}
        print(points);
    }

    public void addPoints(int x){
        points += x;
    }
}
