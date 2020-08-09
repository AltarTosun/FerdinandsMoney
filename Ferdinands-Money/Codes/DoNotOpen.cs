using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class DoNotOpen : MonoBehaviour
{
    public MeshRenderer desktopMesh;
    public bool isCicked;
    private Collider col;
    // Start is called before the first frame update
    void Start()
    {
        isCicked = false;
        desktopMesh = GetComponent<MeshRenderer>();
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (desktopMesh)
        {
            col.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isCicked = true;
        Debug.Log("Clicked!!");
    }
}
