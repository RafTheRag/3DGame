using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : Interactable
{
    public int moneyGoal = 100000;
    private bool enoughMoney;

    public void Update(){
        if(CollectItem.moneyCount >= moneyGoal){
            promptMessage = "Leave";
        }
        else{
            promptMessage = "Collect at least $100k before leaving";
        }
    }

    protected override void Interact(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

