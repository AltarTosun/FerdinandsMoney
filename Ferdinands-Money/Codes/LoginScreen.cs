using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginScreen : MonoBehaviour
{
    
    private PC_Pass_check _passCheck;
    // Start is called before the first frame update
    void Start()
    {
        _passCheck = GameObject.Find("PassScreen").GetComponent<PC_Pass_check>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_passCheck.isLogin)
        {
            gameObject.SetActive(false);
        }
            
        
    }
}
