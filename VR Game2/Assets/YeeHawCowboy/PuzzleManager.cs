using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public bool hasBottle;
    public bool hasGun;
    public bool hasBullets;
    public bool hasKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setBottle(bool isIt)
    {
        hasBottle = isIt;
    }

    public void setGun(bool isIt)
    {
        hasGun = isIt;
    }

    public void setBullets(bool isIt)
    {
        hasBullets = isIt;
    }

    public void setKey(bool isIt)
    {
        hasKey = isIt;
    }
}
