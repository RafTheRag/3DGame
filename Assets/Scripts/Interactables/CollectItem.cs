using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : Interactable
{
    private new Renderer renderer;
    private new Collider collider;
    void Start(){
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
    }
    protected override void Interact(){
        renderer.enabled = false;
        collider.enabled = false;   
        Destroy(gameObject, interactSound.clip.length);
    }
}
