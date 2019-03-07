using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChestOpen()
    {
        GetComponent<Animator>().Play("TreasureChest_OPEN", 0,0.0f);
    }
}
