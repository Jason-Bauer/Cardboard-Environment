using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddtInventory : MonoBehaviour {


    public GameObject pan;
    public GameObject manager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addist(GameObject obj)
    {
        Debug.Log("you clicked a thing");
        Instantiate(obj, pan.transform);
        
    }
}
