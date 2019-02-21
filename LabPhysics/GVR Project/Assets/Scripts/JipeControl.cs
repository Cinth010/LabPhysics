using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JipeControl : MonoBehaviour {

    public GameObject jipe;

    public GameObject playerJ1;
    public GameObject player;
    public GameObject player3;
    public GameObject playerCanvasJ;

    public GameObject canvasK;
    public GameObject canvasJ;

    public Vector3 posJ;
    public Quaternion rotJ;
    public Vector3 pos3;
    public Quaternion rot3;
    public Vector3 posCanvasJ;
    public Quaternion rotCanvasJ;


    public void CamJipe()
    {
        
        if (jipe.activeInHierarchy)
        {
            posJ = playerJ1.transform.position;
            player.transform.position = posJ;
            rotJ = playerJ1.transform.rotation;
            player.transform.rotation = rotJ;

            canvasJ.SetActive(true);
            /* posCanvasJ = playerCanvasJ.transform.position;
            canvasJ.transform.position = posCanvasJ;
            rotCanvasJ = playerCanvasJ.transform.rotation;
            canvasJ.transform.rotation = rotCanvasJ; */

            canvasK.SetActive(false);


        }
        else
        {
            pos3 = player3.transform.position;
            player.transform.position = pos3;
            rot3 = player3.transform.rotation;
            player.transform.rotation = rot3;

            canvasJ.SetActive(true);
            canvasK.SetActive(false);
        }
    }
}
