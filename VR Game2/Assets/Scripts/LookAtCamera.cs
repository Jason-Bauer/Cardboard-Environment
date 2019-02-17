using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Camera.main.transform);
       // transform.localPosition = new Vector3(transform.localPosition.x, -1.062f, transform.localPosition.z);
        transform.Rotate(0, -180.0f, 0);
	}
}
