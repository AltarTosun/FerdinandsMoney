using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class keyLockerManager : MonoBehaviour
{
    public string password;
    public TextMeshPro text;
    public bool isUnlocked;
    public AudioSource AudioSource;
    public AudioClip WrongSound;
    public AudioClip UnlockedSound;
    
    private Rigidbody caseDoor;
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (text.text == password)
        {
            isUnlocked = true;
            AudioSource.PlayOneShot(UnlockedSound);
            text.text = "Unlocked";
        }
        
        else if (text.text != password)
        {
            AudioSource.PlayOneShot(WrongSound);
            text.text = "Incorrect";
        }
    }
}
