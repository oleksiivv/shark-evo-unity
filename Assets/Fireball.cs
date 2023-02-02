using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : BaseMovement
{
    public int dir=1;
    void Start()
    {
        this.speed=0.62f*dir;    
    }

    void Update(){
        transform.Translate(new Vector3(-1,0,0)*speed*Time.timeScale);
    }

}
