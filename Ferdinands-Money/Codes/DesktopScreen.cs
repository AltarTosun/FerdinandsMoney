using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopScreen : MonoBehaviour
{
    private PC_Pass_check _passCheck;
    private DoNotOpen _doNotOpen;
    private MeshRenderer mr;
    
    void Start()
    {
        _passCheck = GameObject.Find("PassScreen").GetComponent<PC_Pass_check>();
        _doNotOpen = GameObject.Find("DoNotOpen").GetComponent<DoNotOpen>();
        mr = GetComponent<MeshRenderer>();
    }
    
    void Update()
    {
        if (_passCheck.isLogin)
        {
            mr.enabled = true;
        }

        if (_doNotOpen.isCicked)
        {
            mr.enabled = false;
        }
    }
}
