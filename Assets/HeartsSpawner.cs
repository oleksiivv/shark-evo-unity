using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsSpawner : MonoBehaviour
{
    public GameObject heart;
    public int posX;

    public Vector2 dy;
    public SharkHealth health;


    void Start(){
        StartCoroutine(spawn());
    }

    IEnumerator spawn(){
        while(true){
            //int n=Random.Range(0, submarine.Length);

            
            if(health.healthSlider.value<60){
                if(PlayerPrefs.GetInt("studied",-1)==1) Instantiate(heart, new Vector3(posX, Random.Range(dy.x, dy.y), heart.transform.position.z), heart.transform.rotation);
            }

            yield return new WaitForSeconds(Random.Range(4.6f,5.9f));
        }
    }
}
