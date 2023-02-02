using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkFX : MonoBehaviour
{
    public ParticleSystem getDamage, attack, attackFish, getStar, getCoin;


    public void playGetDamage(){
        getDamage.Play();
    }

    public void playAttack(){
        attack.Play();
    }

    public void playAttackFish(){
        attackFish.Play();
    }

    public void playGetStar(){
        getStar.Play();
    }

    public void playGetCoin(){
        getCoin.Play();
    }
}
