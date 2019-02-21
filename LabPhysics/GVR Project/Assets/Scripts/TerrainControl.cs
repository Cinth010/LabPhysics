using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainControl : MonoBehaviour
{

    public GameObject jipe;
    public GameObject playerPJ;

    public GameObject terrain1;
    public GameObject terrain2;
    public GameObject rocks1;
    public GameObject rocks2;

    public Vector3 posPJ;
    public Quaternion rotPJ;


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

                posPJ = playerPJ.transform.position;
                jipe.transform.position = posPJ;
                rotPJ = playerPJ.transform.rotation;
                jipe.transform.rotation = rotPJ;
            }
            else
            {
                terrain1.SetActive(false);
                terrain2.SetActive(false);
                rocks1.SetActive(false);
                rocks2.SetActive(false);
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

