using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkCollisions : MonoBehaviour
{
    public SharkHealth health;
    public SharkFX fx;
    public SharkPowerLevel powerLevel;
    public SharkStarsController stars;
    public SharkCoinsController coins;

    public SharkAudioEffects audio;

    private float powerCoef;

    private int x2;

    void Start(){
        powerCoef=1f;
        if(PlayerPrefs.GetInt("item@0")==1){
            powerCoef=1.45f;
        }
        if(PlayerPrefs.GetInt("item@1")==1 || PlayerPrefs.GetInt("item@2")==1){
            powerCoef=1.60f;
        }

        x2=PlayerPrefs.GetInt("item@3")==1?2:1;

    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag=="EnemyGround"){
            health.receiveDamage(100);
            fx.playGetDamage();
        }
        if(other.gameObject.tag=="Enemy"){
            if(SharkHealth.alive){
                other.gameObject.tag="Enemy2";
                
                if(other.gameObject.name.ToUpper().Contains("EASY")){
                    powerLevel.updatePowerLevel(0.15f*powerCoef);
                    health.receiveDamage((100-SharkPowerLevel.powerLevelVal)/20f);
                }
                else if(other.gameObject.name.ToUpper().Contains("MEDIUM")){
                    powerLevel.updatePowerLevel(0.35f*powerCoef);
                    health.receiveDamage((100-SharkPowerLevel.powerLevelVal)/13f);
                }
                else if(other.gameObject.name.ToUpper().Contains("HARD")){
                    powerLevel.updatePowerLevel(0.55f*powerCoef);
                    health.receiveDamage((100-SharkPowerLevel.powerLevelVal)/8f);
                }
                else{
                    powerLevel.updatePowerLevel(1f*powerCoef);
                    health.receiveDamage((100-SharkPowerLevel.powerLevelVal)/2.5f);
                }
                fx.playGetDamage();

                if(SharkPowerLevel.powerLevelVal+powerCoef>=other.gameObject.GetComponent<Submarine>().difficulty){
                    Destroy(other.gameObject);

                    audio.playAttack();

                    fx.playAttack();
                    if(other.gameObject.name.ToUpper().Contains("EASY")){
                        powerLevel.updatePowerLevel(0.35f);
                    }
                    else if(other.gameObject.name.ToUpper().Contains("MEDIUM")){
                        powerLevel.updatePowerLevel(0.65f);
                    }
                    else if(other.gameObject.name.ToUpper().Contains("HARD")){
                        powerLevel.updatePowerLevel(1f);
                    }
                    else{
                        powerLevel.updatePowerLevel(1.25f);
                    }
                }
                else{
                    audio.playDeath();
                }

            }
        }
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="fireball"){
            other.gameObject.tag="Untagged";
            health.receiveDamage((100-SharkPowerLevel.powerLevelVal)/20f);            
            fx.playGetDamage();

            audio.playDeath();
        }
        else if(other.gameObject.tag=="fish"){
            powerLevel.updatePowerLevel(0.5f);
            health.receiveDamage((100-SharkPowerLevel.powerLevelVal)/75f);

            Destroy(other.gameObject);
            fx.playAttackFish();

            audio.playAttack();
        }
        else if(other.gameObject.tag=="star"){
            Destroy(other.gameObject);
            fx.playGetStar();

            stars.updateStarsAmount(5*x2);

            audio.playItemGet();
        }
        else if(other.gameObject.tag=="coin"){
            Destroy(other.gameObject);
            fx.playGetCoin();

            coins.updateCoinsAmount(5*x2);

            audio.playCoinGet();
        }
        else if(other.gameObject.tag=="heart"){
            health.heall(10);
            Destroy(other.gameObject);

            fx.playAttackFish();
            audio.playItemGet();
        }
    }
}
