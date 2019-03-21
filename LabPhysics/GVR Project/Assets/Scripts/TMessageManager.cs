using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TMessageManager : MonoBehaviour {

    public float tempo1 = 6;

    public GameObject pointer;
    public GameObject canvask;
    public GameObject image;
    public GameObject textT;



    public void MessageTerrainOff()
    {

            StartCoroutine(EsperarTempoT(tempo1));        
    }


    IEnumerator EsperarTempoT(float tempo)
    {

        image.SetActive(true);
        textT.SetActive(true);
        pointer.SetActive(false);
        yield return new WaitForSeconds(tempo);
        pointer.SetActive(true);
        textT.SetActive(false);
        image.SetActive(false);
        Destroy(gameObject);


    }
}
