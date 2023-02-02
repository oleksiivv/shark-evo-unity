using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SharkCoinsController : MonoBehaviour
{
    public Text coinsCount;

    void Start(){
        updateCoinsAmount(0);
    }

    public void updateCoinsAmount(int delta){
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins")+delta);

        coinsCount.text=PlayerPrefs.GetInt("coins").ToString();
    }
}
