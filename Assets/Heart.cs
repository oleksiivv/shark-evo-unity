using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : BaseMovement
{
    void Start(){
        gameObject.GetComponent<SpriteRenderer>().sortingOrder=Random.Range(-9,-4);

        this.speed=0.13f;
    }
}
