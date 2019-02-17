using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {

    public GameObject manager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void opensesame()
    {
        if (manager.GetComponent<GM>().hasKey)
        {
            this.gameObject.SetActive(false);
        }
    }
}
