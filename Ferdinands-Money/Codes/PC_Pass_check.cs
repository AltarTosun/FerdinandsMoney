using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PC_Pass_check : MonoBehaviour
{
    public string password;
    public bool isLogin;

    public TextMeshPro text;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (text.text == password && text.text.Length == password.Length)
        {
            isLogin = true;
            text.text = "";
        }
        
        else if (text.text != password && text.text.Length >= password.Length)
        {
            text.text = "";
        }
    }
}
