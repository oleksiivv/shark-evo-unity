using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapsSwitchController : MonoBehaviour
{
    public SpriteRenderer[] maps;

    public Sprite[] mapSprites;


    void Start(){
        foreach(var map in maps){
            map.sprite=mapSprites[PlayerPrefs.GetInt("currentMap",0)];
        }
    }
}
