using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public Camera[] cams;
    
    public void CamMain()
    {
        cams [0].enabled = true;
        cams[1].enabled = false;

    }

    public void CamTwo()
    {
        cams[0].enabled = false;
        cams[1].enabled = true;

    }





}