using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneScreen : MonoBehaviour
{
    public Material verifyScreen;
    public Material defaultScreen;
    private DoNotOpen _doNotOpen;
    private Material[] mats;
    private VerifyButton _phoneScreen;
    private MeshRenderer mr;
    
    void Start()
    {
        _doNotOpen = GameObject.Find("DoNotOpen").GetComponent<DoNotOpen>();
        _phoneScreen = GameObject.Find("VerifyButton").GetComponent<VerifyButton>();
        mr = GetComponent<MeshRenderer>();
        mats = mr.materials;
    }
    void Update()
    {
        if (_doNotOpen.isCicked)
        {
            mats[2] = verifyScreen;
            mr.materials = mats;
        }

        if (_phoneScreen.isVerified)
        {
            mats[2] = defaultScreen;
            mr.materials = mats;
        }
    }
}
