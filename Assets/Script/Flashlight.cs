using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public GameObject flashlight;

    public AudioSource turnOn;
    public AudioSource turnOff;

    public bool off;
    // Start is called before the first frame update
    void Start()
    {
        off = true;
        flashlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) {
            if(off) {
                flashlight.SetActive(true);
                turnOn.Play();
                
            } else {
                flashlight.SetActive(false);
                turnOff.Play();
            }
            off = !off;
        }
    }
}
