using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxKeyLocker : MonoBehaviour
{
    public bool isUnlocked;
    public AudioSource AS;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            AS.Play();
            Debug.Log("Box Unlocked!");
            isUnlocked = true;
        }
    }
}
