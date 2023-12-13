using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;
    public AudioSource sound;
    private bool on, off;
    // Start is called before the first frame update
    void Start()
    {
        off = true;
        flashlight.SetActive(false);
        sound.time = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(off && Input.GetMouseButtonDown(1)){
            flashlight.SetActive(true);
            sound.Play();
            off = false;
            on = true;
        }
        else if(on && Input.GetMouseButtonDown(1)){
            flashlight.SetActive(false);
            sound.Play();
            on = false;
            off = true;
        }
    }
}
