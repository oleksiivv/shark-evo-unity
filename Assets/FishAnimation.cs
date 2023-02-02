using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAnimation : MonoBehaviour
{
    public Sprite[] frames;
    public SpriteRenderer sprite;
    int i=0;

    void Start(){
        StartCoroutine(updateFrame());
    }



    IEnumerator updateFrame(){
        while(true){
            sprite.sprite=frames[i];
            i++;

            if(i>=frames.Length){
                i=0;
            }

            yield return new WaitForSeconds(0.25f);
        }
    }
}
