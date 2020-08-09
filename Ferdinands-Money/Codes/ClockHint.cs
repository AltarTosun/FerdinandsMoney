using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class ClockHint : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUguı;
    private Canvas _panel;
    public bool isTriggered;
    public float timeLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUguı = textMeshProUguı.GetComponent<TextMeshProUGUI>();
        _panel = GameObject.Find("Canvas").GetComponent<Canvas>();
        timeLeft = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered)
        {    
            if(timeLeft >= -1) 
                timeLeft -= Time.deltaTime;
            
            if (timeLeft <= 0)
            {
                _panel.enabled = false;
                textMeshProUguı.enabled = false;
            }
        }
    } 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = true;
            _panel.enabled = true;
            textMeshProUguı.enabled = true;
        }
    }
}

