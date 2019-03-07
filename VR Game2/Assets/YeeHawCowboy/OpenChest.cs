using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
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

    public void ChestOpen()
    {
        if (manager.GetComponent<PuzzleManager>().hasBullets)
        {
            GetComponent<Animator>().Play("TreasureChest_OPEN", 0, 0.0f);
        }
    }
}
