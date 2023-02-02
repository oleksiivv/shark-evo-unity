using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SharkPowerLevel : MonoBehaviour
{

    public static float powerLevelVal=0;
    public Slider powerLevel;


    void Start(){
        powerLevel.minValue=0;
        powerLevel.maxValue=100;

        powerLevel.value=0;
        SharkPowerLevel.powerLevelVal=powerLevel.value;
    }

    public void updatePowerLevel(float n){
        powerLevel.value+=n;
        SharkPowerLevel.powerLevelVal=powerLevel.value;
    }


    
}
