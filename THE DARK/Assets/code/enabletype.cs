using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enabletype : MonoBehaviour
{

    public GameObject typeObj;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
          
            typeObj.SetActive(true);
            //Debug.Log("typeenable_enter");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            typeObj.SetActive(false);

            //Debug.Log("typeenable_exit");
        }
    }

}
