using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VerifyScreen : MonoBehaviour
{
    private DoNotOpen _doNotOpen;
    private VerifyButton _phoneScreen;
    private MeshRenderer mr;
    private Canvas _panel;
    
    public TextMeshProUGUI textMeshProUguı;
    
    // Start is called before the first frame update
    void Start()
    {
        _doNotOpen = GameObject.Find("DoNotOpen").GetComponent<DoNotOpen>();
        _phoneScreen = GameObject.Find("VerifyButton").GetComponent<VerifyButton>();
        mr = GetComponent<MeshRenderer>();
        textMeshProUguı = textMeshProUguı.GetComponent<TextMeshProUGUI>();
        _panel = GameObject.Find("Canvas").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_doNotOpen.isCicked)
        {
            mr.enabled = true;
            _panel.enabled = true;
            textMeshProUguı.enabled = true;
        }
            
        
        if (_phoneScreen.isVerified)
        {
            mr.enabled = false;
            _panel.enabled = false;
            textMeshProUguı.enabled = false;
        }
    }
}
