using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainControlJ : MonoBehaviour {

    public GameObject jipe;

    public GameObject playerJ1;
    public GameObject player;
    public GameObject player3;
    public GameObject playerCanvasJ;
    public GameObject playerPJ;

    public GameObject canvasK;
    public GameObject canvasJ;

    public Vector3 posJ;
    public Quaternion rotJ;
    public Vector3 pos3;
    public Quaternion rot3;
    public Vector3 posCanvasJ;
    public Quaternion rotCanvasJ;
    public Vector3 posPJ;
    public Quaternion rotPJ;

    public GameObject terrain1;
    public GameObject terrain2;
    public GameObject rocks1;
    public GameObject rocks2;


    public void TerrainOnOff()
    {
     
        if (terrain1.activeInHierarchy && terrain2.activeInHierarchy)
        {
            if (jipe.activeInHierarchy)
            {
                terrain1.SetActive(false);
                terrain2.SetActive(false);
                rocks1.SetActive(false);
                rocks2.SetActive(false);

                posJ = playerJ1.transform.position;
                player.transform.position = posJ;
                rotJ = playerJ1.transform.rotation;
                player.transform.rotation = rotJ;

                posPJ = playerPJ.transform.position;
                jipe.transform.position = posPJ;
                rotPJ = playerPJ.transform.rotation;
                jipe.transform.rotation = rotPJ;

                canvasJ.SetActive(true);
                /* posCanvasJ = playerCanvasJ.transform.position;
                canvasJ.transform.position = posCanvasJ;
                rotCanvasJ = playerCanvasJ.transform.rotation;
                canvasJ.transform.rotation = rotCanvasJ; */

                canvasK.SetActive(false);


            }
            else
            {
                terrain1.SetActive(false);
                terrain2.SetActive(false);
                rocks1.SetActive(false);
                rocks2.SetActive(false);

                pos3 = player3.transform.position;
                player.transform.position = pos3;
                rot3 = player3.transform.rotation;
                player.transform.rotation = rot3;

                canvasJ.SetActive(true);
                canvasK.SetActive(false);

            }
           
        }
        else
        {
            terrain1.SetActive(true);
            terrain2.SetActive(true);
            rocks1.SetActive(true);
            rocks2.SetActive(true);

        }
    }


}
