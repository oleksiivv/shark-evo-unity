using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SharkMovement : MonoBehaviour
{
    public Vector2 border;
    public Slider moveSlider;

    public float acceleration;
    public static float speed=1;

    public int startDeg=0;

    void Start(){
        acceleration=0.1f;
        speed=1;

        
    }

    void Update(){
        if(!SharkHealth.alive){
            return;
        }
        Debug.Log("Acceleration:"+(acceleration).ToString());

        if(Input.GetMouseButtonUp(0)){
            //moveSlider.value=0;
            acceleration=0.1f;
        }

        if(Input.GetMouseButton(0)){
            if(acceleration<1)acceleration+=0.0001f*SharkMovement.speed;
        }

        // if(Mathf.Abs(moveSlider.value)<0.5f){
        //     acceleration=0.1f;
        // }


        if(speed<2)speed+=0.001f;
        else if(speed>=2 && speed<3)speed+=0.00008f;
        else speed+=0.00002f;


        if(acceleration>0.1f && ((gameObject.transform.position.y<=border.y && moveSlider.value >=0) || (gameObject.transform.position.y>=border.x && moveSlider.value <=0))){
            gameObject.transform.position+=new Vector3(0,(moveSlider.value-transform.position.y)/1.5f,0)*acceleration;
            transform.eulerAngles=new Vector3(0,0,(moveSlider.value-transform.position.y)*5);
        }
    }
}
