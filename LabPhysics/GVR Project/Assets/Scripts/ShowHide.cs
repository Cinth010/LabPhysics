using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour {

    public GameObject helpObject;
    private bool show = false;

    public void ShowAndHide()
    {

        if (!show)
        {
            helpObject.SetActive(true);
            show = true;
        }
        else
        {
            helpObject.SetActive(false);
            show = false;
        }

    }

}
