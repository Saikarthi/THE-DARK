using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class typevalid : MonoBehaviour
{
    public TMP_InputField inputfield;
    public GameObject welldone, nope;
    [SerializeField]
    private int MaxCharLimt;
    private string c;
    [SerializeField]
    private string code;

    //to disable movement
    public movement_one m1;
    public movement_two m2;
    void Start()
    {
        //limit char 4
        inputfield.characterLimit = MaxCharLimt;
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
            Invoke("sec",5f);
        }
        else
        {
            nope.SetActive(true);
            Invoke("sec2", 2f);

        }
        // Debug.Log(c);


    }

    public void sec()
    {
        welldone.SetActive(false);
        if(SceneManager.GetActiveScene().buildIndex == 4)
        {
            welldone.SetActive(true);
            Invoke("cr", 30f);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
    public void sec2()
    {
        nope.SetActive(false);
    }
    public void cr()
    {
        SceneManager.LoadScene(0);

    }
}
