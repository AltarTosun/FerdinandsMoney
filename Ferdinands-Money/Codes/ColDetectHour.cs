using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColDetectHour : MonoBehaviour
{
    public bool hourOk;
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
        if (other.gameObject.CompareTag("HourCol"))
        {
            hourOk = true;
            Debug.Log("Hour is OK");
        }
    }
}
