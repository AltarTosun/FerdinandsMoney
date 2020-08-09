using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicDrop : MonoBehaviour
{
    private ColDetectHour _detectHour;

    private ColDetectMin _detectMin;
    public AudioSource AS;
    public AudioClip AC;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GameObject.Find("Picture_1").GetComponent<Rigidbody>();
        _detectHour = GameObject.Find("HourCol").GetComponent<ColDetectHour>();
        _detectMin = GameObject.Find("MinCol").GetComponent<ColDetectMin>();
    }

    // Update is called once per frame
    void Update()
    {
       DropCheck();
    }

    private void DropCheck()
    {
        if (_detectHour.hourOk && _detectMin.minOk)
            _rb.useGravity = true;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Floor")
            AS.PlayOneShot(AC);
    }
}
