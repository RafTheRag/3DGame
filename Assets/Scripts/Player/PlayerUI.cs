using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI promptText;
    public TextMeshProUGUI money;
    // Start is called before the first frame update
    void Start()
    {
        money.text = "$0";
    }
    void Update(){
        money.text = "$" + CollectItem.moneyCount;
    }

    // Update is called once per frame
    public void UpdateText(string promptMessage){
        promptText.text = promptMessage;
    }
}
