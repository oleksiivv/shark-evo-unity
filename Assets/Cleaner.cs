using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="decor"
            || other.gameObject.tag=="Enemy" 
            || other.gameObject.tag=="fish" 
            || other.gameObject.tag=="fireball" 
            || other.gameObject.tag=="fireball_shark"
            || other.gameObject.tag=="Enemy2"
            || other.gameObject.tag=="heart"
            || other.gameObject.tag=="coin"
            || other.gameObject.tag=="star"){
            Destroy(other.gameObject);
        }
    }
}
