using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseActivation : MonoBehaviour
{
    private GameObject LostFuse;
    public AudioSource AS;
    public bool isFuseFound;
    
    
    void Start()
    {
        LostFuse = GameObject.Find("LostFuse");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LostFuse"))
        {
            AS.Play();
            Debug.Log("LostFuse Found!");
            isFuseFound = true;
        }
    }
}
