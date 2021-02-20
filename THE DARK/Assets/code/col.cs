using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class col : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    [SerializeField]
    private AudioSource a;


    public win_and_lose w;
    public Light L;
    public Color red;
    public Color green;

    public void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "champ")
        {
            a.Play();

            L.color = green;
            Debug.Log("en");
            anim.enabled = true;
            anim.SetBool("btndown", true);
            anim.SetBool("btnup", false);
            if (this.gameObject.name == "Cube2" || this.gameObject.name == "Cube4")
            {
                w.win += 1;
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "champ")
        {
            a.Play();
            L.color = red;
            Debug.Log("ex");
            anim.SetBool("btndown", false);
            anim.SetBool("btnup", true);
            if (this.gameObject.name == "Cube2" || this.gameObject.name == "Cube4")
            {
                w.win -= 1;
            }
        }
    }
}
