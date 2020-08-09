using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurnOn_TV : MonoBehaviour
{
    public GameObject tvScreen;
    public AudioSource AS;
    public TextMeshProUGUI textMeshProUgui;
    public float timeLeft;
    private Canvas _panel;
    public bool isTriggered;
    
    private FuseActivation _fuseActivation;
    
    void Start()
    {
        _fuseActivation = GameObject.Find("LostFusePlace").GetComponent<FuseActivation>();
        textMeshProUgui = textMeshProUgui.GetComponent<TextMeshProUGUI>();
        _panel = GameObject.Find("Canvas").GetComponent<Canvas>();
        timeLeft = 5;
    }

    private void Update()
    {
        if (isTriggered)
        {    
            if(timeLeft >= -1) 
                timeLeft -= Time.deltaTime;
            
            if (timeLeft <= 0)
            {
                _panel.enabled = false;
                textMeshProUgui.enabled = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        AS.Play();
        
        if (_fuseActivation.isFuseFound && !tvScreen.activeInHierarchy)
            tvScreen.SetActive(true);
        else if (!_fuseActivation.isFuseFound)
        {
            Debug.Log("Fuse is not found yet!");
            isTriggered = true;
            _panel.enabled = true;
            textMeshProUgui.enabled = true;
        }
        
        else if (tvScreen.activeInHierarchy)
            tvScreen.SetActive(false);
    }
}
