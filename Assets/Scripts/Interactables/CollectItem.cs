using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectItem : Interactable
{
    private new Renderer renderer;
    private new Collider collider;
    public static int moneyCount;
    void Start(){
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
        moneyCount = 0;
    }
    protected override void Interact(){
        moneyCount += 10000;
        renderer.enabled = false;
        collider.enabled = false;   
        Destroy(gameObject, interactSound.clip.length);
    }
}
