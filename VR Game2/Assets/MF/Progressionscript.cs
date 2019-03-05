using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Progressionscript : MonoBehaviour
{
    public GameObject pan;
    public Image manager;
    public bool step1 = false;
    public bool step2 = false;
    public bool step3 = false;
    //public GameObject genesis;
    public Image genesis;
    public bool hasGen = false;
    public bool hasbeh = false;

    public Image beach;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setstep1(bool a)
    {
        step1 = a;
    }
    public void setstep2(bool a)
    {
        step2 = a;
    }
    public void setger(bool a)
    {
        hasGen = a;
    }
    public void setbeh(bool a)
    {
        hasbeh = a;
    }

    public void checkadd()
    {
        if (step1)
        {
            addist(genesis);
            hasGen = true;
        }
    }
    
   

    public void addist(Image obj)
    {
        Debug.Log("you clicked a thing");
        Instantiate(obj, pan.transform);

    }
    public void checkadd2()
    {
        if (step2)
        {
            addist(beach);
            hasbeh = true;
        }
    }
}
