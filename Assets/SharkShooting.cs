using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkShooting : MonoBehaviour
{
    public GameObject bullet;


    public void shoot(){
        Instantiate(bullet, gameObject.transform.position+new Vector3(0.5f,0.275f,0), bullet.transform.rotation);
    }
}
