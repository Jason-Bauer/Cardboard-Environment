using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {

    public GameObject InventoryPanel;
    // public Text UIText;
    //public bool textchanged = false;

    //Tutorial Items
    public bool hasKey = false;

    //Horror Items
    public bool horrorLockerKey = false;
    public bool horrorGloves = false;
    public bool horrorScalpel = false;
    public bool horrorEscapeKey = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //tutorial
    public void setkey(bool set)
    {
        hasKey = set;
    }

    public void setHorrorLockerKey(bool set)
    {
        horrorLockerKey = set;
    }

    public void setHorrorGloves (bool set)
    {
        horrorGloves = set;
    }

    public void setHorrorScalpel (bool set)
    {
        horrorScalpel = set;
    }
    public void setHorrorEscapeKey(bool set)
    {
        horrorEscapeKey = set;
    }
}
