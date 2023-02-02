using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    public float speed=1f;

    protected void Update(){
        if(SharkHealth.alive)transform.Translate(new Vector3(-1,0,0)*speed*Time.timeScale);
    }
}
