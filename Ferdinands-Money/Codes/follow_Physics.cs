﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_Physics : MonoBehaviour
{
    public Transform target;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(target.transform.position);
    }
}
