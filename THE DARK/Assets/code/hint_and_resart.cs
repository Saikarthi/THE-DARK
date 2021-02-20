using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hint_and_resart : MonoBehaviour
{
    [SerializeField]
    private GameObject h;
    // to get time left
    [SerializeField]
    public GameObject w;

    public gamemanger g;
    [SerializeField]
    private float TimeForHint;
    //input
    private Player hint;

    int times ;


    private void Awake()
    {
        hint = new Player();
        times = 0;
    }
    private void OnEnable()
    {
        hint.hint.Enable();
       


    }
    private void OnDisable()
    {
       hint.Disable();
    }

       
    // Update is called once per frame
    void Update()
    {
        //press 1 for hint and check runs ones
        if (hint.hint.hint.triggered && times==0)
        {
            
            //hint time
            if(TimeForHint > g.timeleft)
            {
                
                if(w.active == true)
                {
                    times = 0;
                }
                else
                {
                    times = 1;
                    h.SetActive(true);
                   
                    Invoke("sec", 5f);
                }


            }
            else
            {
                w.SetActive(true);
                Invoke("sec2", 2f);

            }

        }
        //press r fot restart
        if (hint.hint.restart.triggered)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    
    void sec()
    {
        h.SetActive(false);

    }
    void sec2()
    {
        w.SetActive(false);

    }
}
