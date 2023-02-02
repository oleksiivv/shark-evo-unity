using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudyController : MonoBehaviour
{
    public GameObject[] panels;
    private int curr;

    void Start(){
        curr=0;

        if(PlayerPrefs.GetInt("studied",-1)==-1){
            next();
        }
    }

    void hideAll(){
        foreach (var item in panels)
        {
            item.SetActive(false);
        }
    }

    void show(int id){
        hideAll();
        panels[id].SetActive(true);
    }

    public void next(){
        
        
        if(curr>=panels.Length){
            hideAll();
            PlayerPrefs.SetInt("studied",1);
        }
        else{
            show(curr);
        }

        curr++;

    }
}
