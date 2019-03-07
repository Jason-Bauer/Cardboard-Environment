using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UseDoor : MonoBehaviour
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

    public void Escape()
    {
        if(manager.GetComponent<PuzzleManager>().hasKey)
        {
            this.gameObject.SetActive(false);
            SceneManager.LoadScene(1);
        }
    }
}
