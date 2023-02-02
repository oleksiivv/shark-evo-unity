using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkEquipment : MonoBehaviour
{
    public GameObject[] equipment;

    public GameObject shootBtn, x2Img;


    void Start(){
        for(int i=0;i<equipment.Length;i++){
            equipment[i].SetActive(PlayerPrefs.GetInt("item@"+i.ToString(),-1)==1);
        }

        
        shootBtn.SetActive(PlayerPrefs.GetInt("item@4",-1)==1);
        x2Img.SetActive(PlayerPrefs.GetInt("item@3",-1)==1);
    }
}
