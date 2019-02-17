using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatetocam : MonoBehaviour {
    public GameObject cam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.localEulerAngles.Set(0, 0, 0);
        // this.gameObject.transform.localRotation.SetEulerAngles(0, cam.transform.localRotation.y*100, 0);
        // Debug.Log(transform.localRotation.x + "," + cam.transform.localRotation.y + "," + transform.localRotation.z + "," + transform.localRotation.w);
    }
}
