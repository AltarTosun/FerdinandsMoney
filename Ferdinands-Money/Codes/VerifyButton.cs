using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerifyButton : MonoBehaviour
{
    private DoNotOpen _doNotOpen;
    public bool isVerified;
    private Collider col;
    // Start is called before the first frame update
    void Start()
    {
        _doNotOpen = GameObject.Find("DoNotOpen").GetComponent<DoNotOpen>();
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_doNotOpen.isCicked)
        {
            col.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isVerified = true;
    }
}
