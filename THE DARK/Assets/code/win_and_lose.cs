using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class win_and_lose : MonoBehaviour
{
    [HideInInspector]
    public int win;
    public GameObject i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(win==2)
        {
            Invoke("HalfASec", 1f);

           
        }
    }
    public void HalfASec()
    {
        i.SetActive(true);
        Invoke("nextscene", 5f);
    }
    public void nextscene()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
