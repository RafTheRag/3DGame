using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string promptMessage;
    public AudioSource interactSound;

    public void BaseInteract(){
        interactSound.Play();
        Interact();
    }

    protected virtual void Interact(){
        
    }
}
