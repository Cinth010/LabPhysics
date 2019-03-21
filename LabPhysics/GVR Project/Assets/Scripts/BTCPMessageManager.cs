using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BTCPMessageManager : MonoBehaviour {

    public float tempo1 = 6;

    public GameObject pointer;
    public GameObject canvask;
    public GameObject textJ;
    public GameObject image;
    public GameObject btK;
    public GameObject btKM;

    public void MessageBTCP()
    {
        if (btKM.activeInHierarchy)
        {
            StartCoroutine(EsperarTempoJ(tempo1));

        }
        else
        {
            btK.SetActive(true);
            Destroy(gameObject);
        }
    }


    IEnumerator EsperarTempoJ(float tempo)
    {

        image.SetActive(true);
        textJ.SetActive(true);
        pointer.SetActive(false);

        yield return new WaitForSeconds(tempo);

        pointer.SetActive(true);
        textJ.SetActive(false);
        image.SetActive(false);
        btK.SetActive(true);
        Destroy(gameObject);


    }
}
