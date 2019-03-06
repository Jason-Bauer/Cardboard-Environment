using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeDoor : MonoBehaviour
{
    public GameObject manager;

    // Update is called once per frame
    public void escape()
    {
        

        if (manager.GetComponent<GM>().horrorEscapeKey)
        {
            //this.gameObject.SetActive(false);
            SceneManager.LoadScene(1);
        }
    }
}
