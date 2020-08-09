using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextClear : MonoBehaviour
{
    public TextMeshPro text;
   
   private void OnTriggerEnter(Collider other)
    { 
        text.text = "";
    }
}
