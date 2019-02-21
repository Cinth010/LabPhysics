using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JipeAdd : MonoBehaviour {

    public GameObject jipeGO;

    public void JipeOnOff()
    {
        if (jipeGO.activeInHierarchy)
        {
            jipeGO.SetActive(false);            
        }
        else
        {
            jipeGO.SetActive(true);
        }
    }


}
