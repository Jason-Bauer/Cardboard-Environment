﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locker : MonoBehaviour
{
    public GameObject gm;
    public GameObject panel;

    public void checkLockerKey()
    {
        if (gm.GetComponent<GM>().horrorLockerKey == true)
        {
            
            gm.GetComponent<GM>().horrorLockerKey = false;
            gameObject.GetComponentInChildren<Animation>().Play();
            gameObject.GetComponentInChildren<AudioSource>().Play();
            //player.GetComponent<GM>().hasGen = false;


        }
    }
}
