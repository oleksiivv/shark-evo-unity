using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    public float mapLength=21.42f;
    private float spawnPoint;
    public SharkMovement shark;
    public float globalSpeed=1;

    public GameObject otherObj;

    void Start(){
        spawnPoint=-mapLength;
        globalSpeed=0.13f;
    }


    void Update(){
        if(SharkHealth.alive)transform.position=Vector3.MoveTowards(transform.position, new Vector3(spawnPoint,0,0),globalSpeed*Time.timeScale);

        if(transform.position.x==spawnPoint){
            transform.position=otherObj.transform.position + new Vector3(mapLength-0.17f,0,0);
        }
    }
}
