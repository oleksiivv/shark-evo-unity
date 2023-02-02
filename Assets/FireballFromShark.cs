using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballFromShark : MonoBehaviour
{
    private ParticleSystem destroyEffect;

    void Start(){
        destroyEffect=gameObject.transform.GetChild(0).gameObject.GetComponent<ParticleSystem>();
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Enemy" || other.gameObject.tag=="fish" || other.gameObject.tag=="fireball"){
            destroyEffect.gameObject.transform.parent=null;
            destroyEffect.Play();
            Destroy(other.gameObject);
        }
    }
}
