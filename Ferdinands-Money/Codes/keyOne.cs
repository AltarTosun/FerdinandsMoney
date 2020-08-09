using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class keyOne : MonoBehaviour
{
    public TextMeshPro text;

    //private keyLockerManager keyLockerManager;

    public string input;
    public AudioSource AudioSource;
    public List<AudioClip> KeySounds;
    
    private BoxCollider collider;
    // Start is called before the first frame update
    void Start()
    {
        //keyLockerManager = GameObject.Find("KeyLockerManager").GetComponent<keyLockerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (keyLockerManager.isUnlocked)
           // collider.isTrigger = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayOneShot(KeySounds[Random.Range(0,2)]);
        if (text.text == "Wrong")
        {
            text.text = "";
            text.text += input;
        }else
            text.text += input;
        
    }
}
