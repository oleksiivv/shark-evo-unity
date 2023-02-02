using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    public GameObject coin;

    public int posX;
    public Vector2 dy;

    void Start(){
        StartCoroutine(coinsSpawner());
    }


    IEnumerator coinsSpawner(){
        while(true){
            
            if(PlayerPrefs.GetInt("studied",-1)==1) {
                int opt=Random.Range(0,6);
                if(opt>=0 && opt<=2){
                    float pos=Random.Range(dy.x, dy.y);
                    Instantiate(coin, new Vector3(posX, pos, coin.transform.position.z), coin.transform.rotation);
                }
                else{
                    float pos=Random.Range(dy.x, dy.y);
                    Instantiate(coin, new Vector3(posX, pos, coin.transform.position.z), coin.transform.rotation);
                    Instantiate(coin, new Vector3(posX, pos+1.5f, coin.transform.position.z), coin.transform.rotation);
                    Instantiate(coin, new Vector3(posX, pos-1.5f, coin.transform.position.z), coin.transform.rotation);

                }
            }

            yield return new WaitForSeconds(3.3f);
        }
    }
}
