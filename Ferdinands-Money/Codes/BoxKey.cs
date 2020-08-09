using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxKey : MonoBehaviour
{
    private BoxKeyLocker _boxKeyLocker;
    public float speed;
    public Transform lastPointKey;
    private OVRGrabbable _ovrGrabbable;

    void Start()
    {
        _boxKeyLocker = GameObject.Find("KeyPlace").GetComponent<BoxKeyLocker>();
        _ovrGrabbable = GetComponent<OVRGrabbable>();
    }
    
    void Update()
    {
        if (_boxKeyLocker.isUnlocked)
        {
            _ovrGrabbable.enabled = false;
            gameObject.isStatic = true;
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, lastPointKey.position, step);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(2, -74, 111), step * 30);
        }
    }
}
