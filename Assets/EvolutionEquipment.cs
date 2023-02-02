using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EvolutionEquipment : MonoBehaviour
{
    public GameObject[] availableObjects;
    public GameObject[] itemPanels;
    public GameObject[] buyEquipments;

    public Text[] prices;

    private List<ShopItem> items=new List<ShopItem>();

    public Text currency;

    void Start(){
        items.Add(new ShopItem(0,400,"Spike"));
        items.Add(new ShopItem(1,800,"SpikeUpper"));
        items.Add(new ShopItem(2,800,"SpikeLower"));
        items.Add(new ShopItem(3,1600,"Jetpack"));
        items.Add(new ShopItem(4,3000,"Weapon"));

        for(int i=0;i<prices.Length;i++){
            prices[i].text=items[i].price.ToString();
        }

        showAvailableItems();

        if(PlayerPrefs.GetInt("first",-1)==-1){
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins")+200);
            PlayerPrefs.SetInt("first",1);
        }

        //PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins")+20000);

        currency.text=PlayerPrefs.GetInt("coins").ToString();
    }


    public void showAvailableItems(){
        for(int i=0;i<availableObjects.Length;i++){
            
            availableObjects[i].SetActive(PlayerPrefs.GetInt("item@"+i.ToString(),-1)==1);
            itemPanels[i].SetActive(PlayerPrefs.GetInt("item@"+i.ToString(),-1)==-1);
            buyEquipments[i].SetActive(false);

        }
    }

    public void hideAllEquipments(){
        for(int i=0;i<availableObjects.Length;i++){
            buyEquipments[i].SetActive(false);
            availableObjects[i].SetActive(PlayerPrefs.GetInt("item@"+i.ToString(),-1)==1);
        }
    }
    public void show(int id){
        hideAllEquipments();
        availableObjects[id].SetActive(true);
        buyEquipments[id].SetActive(true);
    }

    public void buy(int id){

        if(PlayerPrefs.GetInt("coins")>=items[id].price){
            items[id].buy();
            showAvailableItems();
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins")-items[id].price);
            currency.text=PlayerPrefs.GetInt("coins").ToString();
        }
    }

}
