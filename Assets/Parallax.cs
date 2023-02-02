using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public GameObject[] decor;
    public int posX;

    void Start(){
        StartCoroutine(spawn());
    }

    IEnumerator spawn(){
        while(true){
            int n=Random.Range(0, decor.Length);
            Instantiate(decor[n], new Vector3(posX, Random.Range(-6f, -2f), decor[n].transform.position.z), decor[n].transform.rotation);

            yield return new WaitForSeconds(Random.Range(1f,5f));
        }
    }
}
