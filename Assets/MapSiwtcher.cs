using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapSiwtcher : MonoBehaviour
{
    public GameObject[] maps;
    public GameObject[] lockers;
    public int currId;

    public GameObject chooseBtn;

    public int[] requiredHI;
    public Text[] requiredHiText;

    public Text currency;


    void Start(){
        
        //PlayerPrefs.SetInt("stars",28000);

        int n=PlayerPrefs.GetInt("stars");

        currency.text=n.ToString();

        for(int i=requiredHI.Length-1;i>=0;i--){
            if(n>=requiredHI[i]){
                PlayerPrefs.SetInt("Map@"+i.ToString(),1);
            }
        }
        for(int i=0;i<requiredHI.Length;i++){
            requiredHiText[i].text="Required HI>"+requiredHI[i].ToString();
        }


        currId=PlayerPrefs.GetInt("currentMap",0);
        show(currId);
    }

    public void next(){
        currId++;
        if(currId>=maps.Length){
            currId=0;
        }

        show(currId);
    }

    public void prev(){
        currId--;
        if(currId<0){
            currId=maps.Length-1;
        }

        show(currId);
    }

    void show(int id){
        hideAll();

        maps[id].SetActive(true);

        if(PlayerPrefs.GetInt("Map@"+id.ToString())==1 || id==0){
            lockers[id].SetActive(false);

            chooseBtn.SetActive(true);
        }
        else{
            lockers[id].SetActive(true);

            chooseBtn.SetActive(false);
        }
    }

    void hideAll(){
        foreach(var obj in maps){
            obj.SetActive(false);
        }
    }


    public void choose(){
        PlayerPrefs.SetInt("currentMap",currId);
        openScene(3);
        
    }

    public void chooseLevel(int id){
        if(PlayerPrefs.GetInt("Map@"+id.ToString())==1 || id==0){
            PlayerPrefs.SetInt("currentMap",currId);
            openScene(3);
        }
    }

    public GameObject loadingPanel;

    public void openScene(int id){
        Time.timeScale=1;
        loadingPanel.SetActive(true);
        Application.LoadLevelAsync(id);
    }
}
