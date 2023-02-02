using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSubmarine : MonoBehaviour
{
    public GameObject bullet;

    void Start(){
        StartCoroutine(shoot());
    }


    IEnumerator shoot(){
        while(true){
            if(gameObject.transform.position.x<7.5f){
                Instantiate(bullet, gameObject.transform.position+new Vector3(-0.5f,0.275f,0), bullet.transform.rotation);
            }

            yield return new WaitForSeconds(0.45f);
        }
    } 
}
