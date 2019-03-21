using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PCMessageManager : MonoBehaviour {

    public float tempo1 = 6;

    public GameObject pointer;
    public GameObject textPC;
    public GameObject image;
    public GameObject btKM;
    
    public GameObject npc;



    void Update()
    {
        if(npc.activeInHierarchy && btKM.activeInHierarchy)
        {
            StartCoroutine(EsperarTempoPC(tempo1));
        }

        

    }


    IEnumerator EsperarTempoPC(float tempo)
    {

        yield return new WaitForSeconds(tempo);

        image.SetActive(true);
        textPC.SetActive(true);
        pointer.SetActive(false);

        yield return new WaitForSeconds(tempo);

        pointer.SetActive(true);
        textPC.SetActive(false);
        image.SetActive(false);
        gameObject.SetActive(false);


    }
}
