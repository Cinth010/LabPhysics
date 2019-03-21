using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PVCMessageManager : MonoBehaviour {

    public float tempo1 = 6;

    public GameObject pointer;
    public GameObject textPVC;
    public GameObject image;




    public void PVCManager()
    {

            StartCoroutine(EsperarTempoPVC(tempo1));
           

    }


    IEnumerator EsperarTempoPVC(float tempo)
    {

        yield return new WaitForSeconds(tempo);

        image.SetActive(true);
        textPVC.SetActive(true);
        pointer.SetActive(false);

        yield return new WaitForSeconds(tempo);

        pointer.SetActive(true);
        textPVC.SetActive(false);
        image.SetActive(false);
        Destroy(gameObject);


    }
}
