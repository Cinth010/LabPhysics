﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour {


    public GameObject player;
    public GameObject player1;
    public GameObject player2;
    public Vector3 pos1;
    public Quaternion rot1;
    public Vector3 pos2;
    public Quaternion rot2;

    public void Change1()
    {
        pos2 = player2.transform.position;
        player.transform.position = pos2;
        rot2 = player2.transform.rotation;
        player.transform.rotation = rot2;
       
    }

    public void ChangeOrig()
    {
        pos1 = player1.transform.position;
        player.transform.position = pos1;
        rot1 = player1.transform.rotation;
        player.transform.rotation = rot1;

    }
  
}
