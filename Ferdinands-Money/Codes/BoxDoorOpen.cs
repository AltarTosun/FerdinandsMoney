using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoxDoorOpen: MonoBehaviour
{
    public float timeLeft;
    public float doorOpenAngle = 90f;
    public float smooth = 2f;
    private BoxKeyLocker _boxKeyLocker;
    private Canvas _panel;
    public TextMeshProUGUI textMeshProUguı;
    // Start is called before the first frame update
    void Start()
    {
        _boxKeyLocker = GameObject.Find("KeyPlace").GetComponent<BoxKeyLocker>();
        _panel = GameObject.Find("Canvas").GetComponent<Canvas>();
        textMeshProUguı = textMeshProUguı.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_boxKeyLocker.isUnlocked)
        {
            Quaternion targetRotation2 = Quaternion.Euler(doorOpenAngle,0,0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
            
            _panel.enabled = true;
            textMeshProUguı.enabled = true;
            
            if(timeLeft >= -1) 
                timeLeft -= Time.deltaTime;
            
            if (timeLeft <= 0)
            {
                _panel.enabled = false;
                textMeshProUguı.enabled = false;
            }
        }
    }
}