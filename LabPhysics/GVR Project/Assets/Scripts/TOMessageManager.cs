using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TOMessageManager : MonoBehaviour {

    public float tempo1 = 6;

    public GameObject pointer;
    public GameObject textTO;
    public GameObject GB_TKMC;
    public GameObject image;
    
    public GameObject terrain;



    void Update()
    {
        if(GB_TKMC.activeInHierarchy && !terrain.activeInHierarchy)
        {
            StartCoroutine(EsperarTempoP(tempo1));
        }
        

    }


    IEnumerator EsperarTempoP(float tempo)
    {

        image.SetActive(true);
        textTO.SetActive(true);
        pointer.SetActive(false);

        yield return new WaitForSeconds(tempo);

        pointer.SetActive(true);
        textTO.SetActive(false);
        image.SetActive(false);
        GB_TKMC.SetActive(false);
        Destroy(gameObject);


    }
}
