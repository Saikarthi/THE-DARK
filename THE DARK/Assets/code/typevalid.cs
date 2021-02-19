using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class typevalid : MonoBehaviour
{
    public TMP_InputField inputfield;
    public GameObject welldone, nope;

    private string c;
    [SerializeField]
    private string code;
    void Start()
    {
        inputfield.characterLimit = 4;
        inputfield.onValidateInput += delegate (string s, int i, char c) { return char.ToUpper(c); };
    }
    
    void Update()
    {
    }


    public void okay()
    {
        c = inputfield.text;
        if(c==code)
        {
            welldone.SetActive(true);
            Invoke("sec5",2f);
        }
        else
        {
            nope.SetActive(true);
            Invoke("sec5", 2f);

        }
        // Debug.Log(c);


    }

    public void sec5()
    {
        welldone.SetActive(false);
        nope.SetActive(false);
    }
}
