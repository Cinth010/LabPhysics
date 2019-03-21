using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PMessageManager : MonoBehaviour {

    public float tempo1 = 6;

    public GameObject pointer;
    public GameObject canvask;
    public GameObject textP;
    public GameObject image;
    public GameObject btK;


    public void MessagePerson()
    {
          
          StartCoroutine(EsperarTempoP(tempo1));
    }


    IEnumerator EsperarTempoP(float tempo)
    {

        image.SetActive(true);
        textP.SetActive(true);
        pointer.SetActive(false);

        yield return new WaitForSeconds(tempo);

        pointer.SetActive(true);
        textP.SetActive(false);
        image.SetActive(false);
        btK.SetActive(true);
        Destroy(gameObject);


    }
}
