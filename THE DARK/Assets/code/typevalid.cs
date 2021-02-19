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

    //to disable movement
    public movement_one m1;
    public movement_two m2;
    void Start()
    {
        //limit char 4
        inputfield.characterLimit = 4;
        //limit all to caps
        inputfield.onValidateInput += delegate (string s, int i, char c) { return char.ToUpper(c); };
    }
    
    public void  disblecode_usebtnclicked()
    {
        m1.enabled = false;
        m2.enabled = false;
    }

    public void enablecode_cancelbtnclicked()
    {
        m1.enabled = true;
        m2.enabled = true;
    }

    public void okay()
    {
        m1.enabled = true;
        m2.enabled = true;
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
