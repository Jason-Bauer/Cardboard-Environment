using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class RecordPlayer : MonoBehaviour
{
    public AudioSource gen;
    public AudioSource beh;
    public Text TV;
    public GameObject player;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void check12()
    {
        if (player.GetComponent<Progressionscript>().hasGen)
        {
            beh.Play();
            player.GetComponent<Progressionscript>().step2 = true;
            TV.text = "That's not Genesis";
            player.GetComponent<Progressionscript>().hasGen = false;


        }
    }
    public void check123()
    {
        if (player.GetComponent<Progressionscript>().hasbeh)
        {
            beh.Stop();
            gen.Play();
            player.GetComponent<Progressionscript>().step3 = true;
            TV.text = "What's that number?";
            player.GetComponent<Progressionscript>().hasbeh = false;
            panel.gameObject.SetActive(true);
        }
    }

}
