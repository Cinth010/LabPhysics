using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangePosition : MonoBehaviour {
    
    public GameObject player;
    public GameObject camPlayer;
    public GameObject player1;
    public GameObject player2;
    public GameObject playerPO;
    public GameObject canvasPO;
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject npc;
    public GameObject npc1;
    public GameObject kombi;
    public GameObject PVCManagerC;
       
    public Vector3 pos1;
    public Quaternion rot1;
    public Vector3 pos2;
    public Quaternion rot2;

    public float tempo1 = 6;

    public GameObject pointer;
    public GameObject canvask;
    public GameObject textPVC;
    public GameObject image;
    public GameObject btK;



    public void ChangePerson()
    {

        if (npc.activeInHierarchy)
        {
            npc1.SetActive(false);
            player.transform.parent = null;
            npc.transform.parent = null;
            canvas2.transform.parent = null;
            canvas2.SetActive(true);
            canvas1.SetActive(false);
            pos2 = player2.transform.position;
            player.transform.position = pos2;
            rot2 = player2.transform.rotation;
            player.transform.rotation = rot2;
            camPlayer.transform.rotation = npc.transform.rotation;
            if (PVCManagerC.activeInHierarchy) { 
                StartCoroutine(EsperarTempoPVC(tempo1));
            }
        }
        else
        {
            player.transform.parent = null;
            npc.transform.parent = null;
            canvas2.transform.parent = null;
            canvas2.SetActive(true);
            canvas1.SetActive(false);
            pos2 = player2.transform.position;
            player.transform.position = pos2;
            rot2 = player2.transform.rotation;
            player.transform.rotation = rot2;
            camPlayer.transform.rotation = npc.transform.rotation;
            if (PVCManagerC.activeInHierarchy) {
                StartCoroutine(EsperarTempoPVC(tempo1));
            }
        }

                          
    }

    public void ChangeOrigK()
    {

            player.transform.parent = kombi.transform;
            camPlayer.transform.rotation = player1.transform.rotation;
            npc.transform.SetPositionAndRotation(playerPO.transform.position, playerPO.transform.rotation);
            npc.transform.parent = kombi.transform;
            canvas2.transform.parent = kombi.transform;
            canvas2.transform.position = canvasPO.transform.position;
            pos1 = player1.transform.position;
            player.transform.position = pos1;
            rot1 = player1.transform.rotation;
            player.transform.rotation = rot1;
            canvas1.SetActive(true);
            canvas2.SetActive(false);
    }


    IEnumerator EsperarTempoPVC(float tempo)
    {

        image.SetActive(true);
        textPVC.SetActive(true);
        pointer.SetActive(false);

        yield return new WaitForSeconds(tempo);

        pointer.SetActive(true);
        textPVC.SetActive(false);
        image.SetActive(false);
        PVCManagerC.SetActive(false);
    }
}




