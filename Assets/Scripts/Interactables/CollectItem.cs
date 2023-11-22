using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItem : Interactable
{
    // Start is called before the first frame update
    protected override void Interact(){
        Destroy(gameObject);
    }
}
