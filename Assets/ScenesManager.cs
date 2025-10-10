using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesManager : MonoBehaviour
{
    public GameObject loadingPanel;

    void Start(){
        Time.timeScale = 1;
        
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 50;
    }

    public void openScene(int id){
        loadingPanel.SetActive(true);
        Application.LoadLevelAsync(id);
    }
}
