using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class PanelsController : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject deathPanel;

    public GameObject loadingPanel;

#if UNITY_IOS
    private string appId="4268466";
#else
    private string appId="4268467";
#endif

    public static int addCnt=1;

    public AdmobController admob;

    void Start(){
        Advertisement.Initialize(appId, false);
    }

    public void pause(){
        Time.timeScale=0;
        pausePanel.SetActive(true);

        if(addCnt%3==0){
            if(Advertisement.IsReady("Interstitial_Android") ){
                Advertisement.Show("Interstitial_Android");
            }
        }
        addCnt++;
    }

    public void resume(){
        Time.timeScale=1;
        pausePanel.SetActive(false);
    }

    public void openScene(int id){
        Time.timeScale=1;
        loadingPanel.SetActive(true);
        Application.LoadLevelAsync(id);
    }

    public void restart(){
        openScene(Application.loadedLevel);
    }

    private bool adsAlreadyShowed = false;
    
    public void setDeathPanelVisibility(bool visible){
        deathPanel.SetActive(visible);

        if(addCnt%3==0 && !adsAlreadyShowed){
            bool showedAdmob = admob.showIntersitionalAd();
            if(!showedAdmob){
                if(Advertisement.IsReady("Interstitial_Android") ){
                    Advertisement.Show("Interstitial_Android");
                    adsAlreadyShowed=true;
                }
            }else{
                adsAlreadyShowed=true;
            }
        }

        addCnt++;
    }

}
