using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColDetectMin : MonoBehaviour
{
    public bool minOk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MinCol"))
        {
            minOk = true;
            Debug.Log("Minute is OK");
        }
    }
}
