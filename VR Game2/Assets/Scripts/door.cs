using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour {

    public GameObject manager;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void opensesame(int load)
    {
        if (manager.GetComponent<GM>().hasKey)
        {
            this.gameObject.SetActive(false);
            SceneManager.LoadScene(load);
        }
    }
}
