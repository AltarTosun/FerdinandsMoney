using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LostFuse : MonoBehaviour
{
    public Transform lastPoint;
    public float speed;
    private OVRGrabbable _ovrGrabbable;
    private FuseActivation _fuseActivation;

    void Start()
    {
        _fuseActivation = GameObject.Find("LostFusePlace").GetComponent<FuseActivation>();
        _ovrGrabbable = GetComponent<OVRGrabbable>();
    }
    void Update()
    {
        if (_fuseActivation.isFuseFound)
        {
            _ovrGrabbable.enabled = false;
            gameObject.isStatic = true;
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, lastPoint.position, step);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 90, 0), step * 50);
            
        }
    }
}
