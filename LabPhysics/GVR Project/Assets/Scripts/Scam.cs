using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scam : MonoBehaviour
{

    public GameObject player;
    public GameObject playerT;
    public GameObject kombi;
    public GameObject playerK;

    public GameObject canvasT;
    public GameObject canvasK;
    public GameObject npc;


    public Vector3 posT;
    public Quaternion rotT;
    public Vector3 posK;
    public Quaternion rotK;

    public void CamT()
    {
        player.transform.parent = playerT.transform;

        posT = playerT.transform.position;
        player.transform.position = posT;
        rotT = playerT.transform.rotation;
        player.transform.rotation = rotT;

        canvasT.SetActive(true);
        canvasK.SetActive(false);
        npc.SetActive(false);
    }

    public void CamK()
    {
        player.transform.parent = kombi.transform;

        posK = playerK.transform.position;
        player.transform.position = posK;
        rotK = playerK.transform.rotation;
        player.transform.rotation = rotK;

        canvasK.SetActive(true);
        canvasT.SetActive(false);
        npc.SetActive(true);
    }


}
