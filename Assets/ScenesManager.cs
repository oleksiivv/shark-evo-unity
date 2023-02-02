using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenesManager : MonoBehaviour
{
    public GameObject loadingPanel;

    public void openScene(int id){
        loadingPanel.SetActive(true);
        Application.LoadLevelAsync(id);
    }
}
