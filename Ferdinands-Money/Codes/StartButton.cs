using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public GameObject canvas_Start;
    private void OnTriggerEnter(Collider other)
    {
        canvas_Start.SetActive(false);
    }
}
