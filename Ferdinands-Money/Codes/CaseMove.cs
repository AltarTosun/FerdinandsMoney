using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseMove : MonoBehaviour
{
    private ColDetectHour _detectHour;
    private ColDetectMin _detectMin;
    public AudioClip MoveSound;
    public AudioSource AudioSource;
    public Transform lastPoint;
    public bool isPlaying ;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        _detectHour = GameObject.Find("HourCol").GetComponent<ColDetectHour>();
        _detectMin = GameObject.Find("MinCol").GetComponent<ColDetectMin>();
        isPlaying = true;
    }
    
    void Update()
    {
        MoveCheck();
    }

    private void MoveCheck()
    {
        if (_detectHour.hourOk && _detectMin.minOk)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, lastPoint.position, step);
            
            if(isPlaying && !AudioSource.isPlaying)
            {
                AudioSource.PlayOneShot(MoveSound);
                isPlaying = false;
            }
        }
    }
}
