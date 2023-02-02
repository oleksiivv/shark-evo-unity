using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineSpawner : MonoBehaviour
{
    public GameObject[] submarine;
    public int posX;

    public Vector2 dy;

    void Start(){
        StartCoroutine(spawn());
    }

    IEnumerator spawn(){
        while(true){
            int n=Random.Range(0, submarine.Length);
            if(PlayerPrefs.GetInt("studied",-1)==1) Instantiate(submarine[n], new Vector3(posX, Random.Range(dy.x, dy.y), submarine[n].transform.position.z), submarine[n].transform.rotation);

            yield return new WaitForSeconds(Random.Range(0.6f,1.9f));
        }
    }
}
