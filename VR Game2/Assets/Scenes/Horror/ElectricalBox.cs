using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalBox : MonoBehaviour
{
    public GameObject gm;
    public GameObject panel;
    public GameObject light;
    public GameObject door;

    public void checkGlove()
    {
        if (gm.GetComponent<GM>().horrorGloves == true)
        {

            gm.GetComponent<GM>().horrorGloves = false;
            door.GetComponent<Animator>().SetBool("DoorOpen", true);
            light.GetComponentInChildren<Light>().enabled = false;
            

        }
    }

    public void TriggerTextEnter()
    {
        if (gm.GetComponent<GM>().horrorGloves == true)
        {
            gm.GetComponent<TextControl>().SetText("I think broke it. at least the doors seems to have opened");
        }
        else
        {
            gm.GetComponent<TextControl>().SetText("The box is electrified, I can't touch it");
        }
    }

    public void TriggerTextExit()
    {
        if (gm.GetComponent<GM>().horrorGloves == true)
        {
            gm.GetComponent<TextControl>().flipText();
        }
        else
        {
            gm.GetComponent<TextControl>().flipText();
        }
    }
}
