using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageIManager : MonoBehaviour
{
  
    public float tempo1 = 6;
    
    public GameObject player;
   
    public GameObject canvask;
    public GameObject canvasKM;
    public GameObject canvasI;
    
    AudioListener audio1;

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(EsperarTempoI(tempo1));

    }


    IEnumerator EsperarTempoI(float tempo)
    {

            canvasI.SetActive(true);
            //audio1 = player.GetComponent<AudioListener>();
            // audio1.enabled = false;
            canvask.SetActive(false);
            canvasKM.SetActive(false);
            yield return new WaitForSeconds(tempo);
            canvask.SetActive(true);
            canvasKM.SetActive(true);
            //audio1.enabled = true;
            canvasI.SetActive(false);
            Destroy(gameObject);
            
        
    }

}