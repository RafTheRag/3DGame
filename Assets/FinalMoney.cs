using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalMoney : MonoBehaviour
{
    
    void Start()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = "Collected $" + CollectItem.moneyCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
