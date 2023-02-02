using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuController : MonoBehaviour
{
    public Text hiScore;

    void Start(){
        if(PlayerPrefs.GetInt("hi",-1)==-1){
            hiScore.gameObject.SetActive(false);
        }
        else{
            hiScore.text="Best distance: "+PlayerPrefs.GetInt("hi").ToString()+"m";
        }
    }

}
