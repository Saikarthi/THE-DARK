using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hint_and_resart : MonoBehaviour
{
    [SerializeField]
    private GameObject h;
    // to get time left
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
    void Start()
    {

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
                times = 1;
                h.SetActive(true);
                //run after 5f
                Invoke("sec", 5f);
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
}
