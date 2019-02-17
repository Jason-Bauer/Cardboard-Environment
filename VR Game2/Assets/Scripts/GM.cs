using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

    public GameObject InventoryPanel;
    // public Text UIText;
    //public bool textchanged = false;
    public bool hasKey = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void setkey(bool set)
    {
        hasKey = set;
    }
}
