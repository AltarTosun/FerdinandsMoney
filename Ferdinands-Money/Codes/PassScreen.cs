using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassScreen : MonoBehaviour
{
    private VerifyButton _phoneScreen;

    private MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
        _phoneScreen = GameObject.Find("VerifyButton").GetComponent<VerifyButton>();
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_phoneScreen.isVerified)
        {
            mr.enabled = true;
        }
    }
}
