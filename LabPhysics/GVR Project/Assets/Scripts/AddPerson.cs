using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPerson : MonoBehaviour
{

    public GameObject person;
    public GameObject canvasT;
    public GameObject personOrig;
    public GameObject kombi;
    public GameObject imagePVC;
    public GameObject textPVC;

    public void LeavePerson()
    {
        if (person.activeInHierarchy)
        {
            person.SetActive(false);
            person.transform.SetPositionAndRotation(personOrig.transform.position, personOrig.transform.rotation);
            person.transform.parent = kombi.transform;
        }
        else
        {
            person.SetActive(true);
            canvasT.transform.parent = null;
            imagePVC.transform.parent = canvasT.transform;
            textPVC.transform.parent = canvasT.transform;
            person.transform.parent = null;
        }

    }


}
