using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weebPuzzle : MonoBehaviour
{

   public bool hasYellow = false;
    public bool hasRed = false;
    public bool hasGreen = false;
    public bool hasBlue = false;

    public bool poster = false;

    public bool hasKey = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasYellow==true && hasRed==true&&hasBlue==true&&hasGreen==true&&poster==true)
        {
            GameObject.Find("Laptop_Off").active = false;
            hasYellow = false;
        }
    }

    public void hasyellow()
    {
        hasYellow = true;
    }

    public void hasposter()
    {
        poster = true;
    }

    public void hasred()
    {
        hasRed = true;
    }

    public void hasgreen()
    {
        hasGreen = true;
    }

    public void hasblue()
    {
        hasBlue= true;
    }

    public void haskey()
    {
        hasKey = true;
    }


}
