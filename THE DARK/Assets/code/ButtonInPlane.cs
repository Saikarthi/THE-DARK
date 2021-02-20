using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInPlane : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    //[SerializeField]
    //private AudioSource a;


    public win_and_lose w;
    public Light L;
    public Color red;
    public Color green;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "champ")
        {


            //a.Play();
            L.color = green;
            //amimation
            anim.enabled = true;
            anim.SetBool("btndown", true);
            anim.SetBool("btnup", false);
            if (this.gameObject.name == "Cube2" || this.gameObject.name == "Cube4")
            {
                w.win += 1;
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "champ")
        {


           // a.Play();

            L.color = red;
            //animation
            anim.SetBool("btndown", false);
            anim.SetBool("btnup", true);
            if (this.gameObject.name == "Cube2" || this.gameObject.name == "Cube4")
            {
                w.win -= 1;
            }

        }
        
    }
    
}
