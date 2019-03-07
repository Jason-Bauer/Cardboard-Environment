using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class weebdoor : MonoBehaviour
{
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void leave()
    {
        if(manager.GetComponent<weebPuzzle>().hasKey)
        {
            this.gameObject.SetActive(false);
            SceneManager.LoadScene(1);
        }
    }
}
