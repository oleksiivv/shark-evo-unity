using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SharkHealth : MonoBehaviour
{
    public Slider healthSlider;
    public static bool alive=true;

    public PanelsController panels;

    public Animator anim;
    public Rigidbody2D rb;


    void Start(){

        alive=true;

        healthSlider.minValue=0;
        healthSlider.maxValue=100;

        healthSlider.value=100;
    }

    public void receiveDamage(float n){
        healthSlider.value-=n;
        if((int)healthSlider.value==0){
            SharkHealth.alive=false;
            panels.setDeathPanelVisibility(true);
            anim.enabled=false;
            rb.gravityScale=5;
        }
    }

    public void heall(float n){
        if(healthSlider.value+n>100){
            healthSlider.value=100;
        }
        else{
            healthSlider.value+=n;
        }
    }
}
