using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CaseDoorOpen : MonoBehaviour
{
    public float doorOpenAngle = 90f;
    public float smooth = 2f;
    private keyLockerManager _keyLockerManager;
    
    // Start is called before the first frame update
    void Start()
    {
        _keyLockerManager = GameObject.Find("PassEnter").GetComponent<keyLockerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_keyLockerManager.isUnlocked)
        {
            Quaternion targetRotation2 = Quaternion.Euler(0,doorOpenAngle,0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
        }
    }
}
