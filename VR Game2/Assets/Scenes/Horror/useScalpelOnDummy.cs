using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useScalpelOnDummy : MonoBehaviour
{
    public GameObject gm;
    public GameObject panel;
    public GameObject key;
    //public GameObject inventoryItem;
    public GameObject prefab;

    public void useScapelOnDummy()
    {
        if (gm.GetComponent<GM>().horrorScalpel == true)
        {

            gm.GetComponent<GM>().horrorScalpel = false;
            gm.GetComponent<GM>().horrorEscapeKey = true;
            key.GetComponent<AddtInventory>().addist(prefab);
            key.SetActive(false);


        }
    }
}
