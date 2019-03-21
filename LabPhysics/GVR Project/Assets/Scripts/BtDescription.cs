using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BtDescription : MonoBehaviour {

    public GameObject bt_tx;

    public void Tx_On()
    {

        bt_tx.SetActive(true);

    }

    public void Tx_Off()
    {

        bt_tx.SetActive(false);

    }
}
