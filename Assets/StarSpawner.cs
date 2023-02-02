using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject star;

    public int posX;
    public Vector2 dy;

    void Start(){
        StartCoroutine(starsSpawner());
    }


    IEnumerator starsSpawner(){
        while(true){
            
            yield return new WaitForSeconds(4.5f);
            
            if(PlayerPrefs.GetInt("studied",-1)==1){ 
                int opt=Random.Range(0,6);
                if(opt>=0 && opt<=2){
                    float pos=Random.Range(dy.x, dy.y);
                    Instantiate(star, new Vector3(posX, pos, star.transform.position.z), star.transform.rotation);
                }
                else{
                    float pos=Random.Range(dy.x, dy.y);
                    Instantiate(star, new Vector3(posX, pos, star.transform.position.z), star.transform.rotation);
                    Instantiate(star, new Vector3(posX, pos+1.5f, star.transform.position.z), star.transform.rotation);
                    Instantiate(star, new Vector3(posX, pos-1.5f, star.transform.position.z), star.transform.rotation);

                }
            }
            /*else{
                float pos=Random.Range(dy.x, dy.y);
                Instantiate(star, new Vector3(posX, pos, star.transform.position.z), star.transform.rotation);
                Instantiate(star, new Vector3(posX, pos+1.5f, star.transform.position.z), star.transform.rotation);
                Instantiate(star, new Vector3(posX, pos-1.5f, star.transform.position.z), star.transform.rotation);
                
                Instantiate(star, new Vector3(posX-1.5f, pos, star.transform.position.z), star.transform.rotation);
                Instantiate(star, new Vector3(posX-1.5f, pos+1.5f, star.transform.position.z), star.transform.rotation);
                Instantiate(star, new Vector3(posX-1.5f, pos-1.5f, star.transform.position.z), star.transform.rotation);
            }
            else{
                float pos=Random.Range(-2f,0f);
                Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos, spawnPosY,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos+1, spawnPosY+1,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos-1, spawnPosY+1,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                float pos2=Random.Range(0f,2f);
                Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos2, spawnPosY,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos2+1, spawnPosY+1,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
                Instantiate(fishes[Random.Range(0, fishes.Length)], new Vector3(pos2-1, spawnPosY+1,0), fishes[Random.Range(0, fishes.Length)].transform.rotation);
            }*/

        }
    }
}
