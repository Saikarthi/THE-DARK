using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemanger : MonoBehaviour
{
    [SerializeField]
    Image timebar;
    [SerializeField]
    private float maxtime=5f;
    [HideInInspector]
    public float timeleft;
    public GameObject gameover;
    void Start()
    {
        timeleft = maxtime;
    }

    void Update()
    {
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            timebar.fillAmount = timeleft / maxtime;
        }
        else
        {
            gameover.SetActive(true);
            Invoke("level1", 3f);
            
        }

    }
    public void level1()
    {
        SceneManager.LoadScene(0);
    }
}
