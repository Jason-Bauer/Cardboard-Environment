﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableFlip : MonoBehaviour
{
    public GameObject manager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FlipIt()
    {
        if (manager.GetComponent<PuzzleManager>().hasBottle)
        {
            GetComponent<Animation>().Play();
        }
    }
}
