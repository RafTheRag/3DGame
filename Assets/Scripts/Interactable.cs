using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string promptMessage;
    public AudioSource interactSound;
    public bool useEvents;

    public void BaseInteract(){
        if(useEvents){
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        }
        interactSound.Play();
        Interact();
    }

    protected virtual void Interact(){
        
    }
}
