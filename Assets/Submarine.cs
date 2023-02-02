using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submarine : BaseMovement
{
    public Color32 canBeDestroyed, cannotBeDestroyed;

    public int difficulty;
    public float level;
    void Start(){
        this.speed=0.2f*level;
    }


    void Update(){
        base.Update();
        if(SharkPowerLevel.powerLevelVal>=difficulty){
            gameObject.GetComponent<SpriteRenderer>().color=canBeDestroyed;
        }
        else{
            gameObject.GetComponent<SpriteRenderer>().color=cannotBeDestroyed;
        }
    }
    
}
