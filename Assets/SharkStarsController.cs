using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SharkStarsController : MonoBehaviour
{
    public Text starsCount;

    void Start(){
        updateStarsAmount(0);
    }

    public void updateStarsAmount(int delta){
        PlayerPrefs.SetInt("stars", PlayerPrefs.GetInt("stars")+delta);

        starsCount.text=PlayerPrefs.GetInt("stars").ToString();
    }
}
