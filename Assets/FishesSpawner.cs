using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishesSpawner : MonoBehaviour
{
    public GameObject[] fishes;
    public int posX;

    public Vector2 dy;
    private float delayCoef=1;

    void Start(){
        StartCoroutine(spawn());
    }

    IEnumerator spawn(){
        while(true){
            // int n=Random.Range(0, fishes.Length);
            // Instantiate(fishes[n], new Vector3(posX, Random.Range(dy.x, dy.y), fishes[n].transform.position.z), fishes[n].transform.rotation);

            // yield return new WaitForSeconds(Random.Range(0.6f,1.9f));
            if(PlayerPrefs.GetInt("studied",-1)==1) {
                int n=Random.Range(0, fishes.Length);
                int opt=Random.Range(0,6);
                if(opt==0){
                    float pos=Random.Range(dy.x, dy.y);
                    Instantiate(fishes[n], new Vector3(Random.Range(-2.5f,2.5f), pos,fishes[n].transform.position.z), fishes[n].transform.rotation);
                }
                else if(opt==1){
                    float pos=Random.Range(dy.x, dy.y);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(posX, pos, fishes[n].transform.position.z), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(posX, pos+1,fishes[n].transform.position.z), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(posX, pos-1,fishes[n].transform.position.z), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                }
                else{
                    float pos=Random.Range(dy.x, dy.y);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(posX, pos, fishes[n].transform.position.z), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(posX, pos+1,fishes[n].transform.position.z), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(posX, pos-1,fishes[n].transform.position.z), fishes[Random.Range(0, fishes.Length)].transform.rotation);

                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(posX+2, pos,fishes[n].transform.position.z), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(posX-2, pos,fishes[n].transform.position.z), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                }
                /*else{
                    float pos=Random.Range(-2f,0f);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos, spawnPosY,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos+1, spawnPosY+1,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos-1, spawnPosY+1,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                    float pos2=Random.Range(0f,2f);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos2, spawnPosY,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos2+1, spawnPosY+1,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                    Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos2-1, spawnPosY+1,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                }*/

                if(delayCoef>0.3f)delayCoef*=0.992f;
                Debug.Log("Delay: "+delayCoef.ToString());
            }
            yield return new WaitForSeconds(Random.Range(1.6f,2.9f)*delayCoef);
        }
    }
}
