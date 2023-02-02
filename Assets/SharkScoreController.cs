using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SharkScoreController : MonoBehaviour
{
    public Text score;
    public Text hi;
    public Text newHiLabel;

    private float scoreVal;
    private bool hiLabelShowed;
    public int coefSpeed=1;


    void Start(){
        hi.text=PlayerPrefs.GetInt("hi").ToString()+"m";
        scoreVal=0f;

        hiLabelShowed=PlayerPrefs.GetInt("hi",-1)==-1;

        coefSpeed=PlayerPrefs.GetInt("item@3")==1?2:1;
        StartCoroutine(scoreIncr());
    }



    IEnumerator scoreIncr(){
        while(true){
            if(SharkHealth.alive){
                if(PlayerPrefs.GetInt("studied",-1)==1) scoreVal+=1*coefSpeed;
                score.text="Distance "+((int)scoreVal).ToString()+"m";
                
            }
            if((int)scoreVal>PlayerPrefs.GetInt("hi")){
                if(PlayerPrefs.GetInt("hi")!=0 && !hiLabelShowed && Mathf.Abs(PlayerPrefs.GetInt("hi")-(int)scoreVal)>0){
                    hiLabelShowed=true;
                    newHiLabel.gameObject.SetActive(true);
                }
                PlayerPrefs.SetInt("hi",(int)scoreVal);
                hi.text=PlayerPrefs.GetInt("hi").ToString()+"m";
            }

            yield return new WaitForSeconds(0.75f);
        }
    }
}
