using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextProg : MonoBehaviour
{
    public GameObject panelh, texth;
    public bool S1, S2, S3, S4, S5, Texthold;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Texthold)
        {
            if (S1)
            {
                texth.GetComponent<Text>().text = "Table 7 Needs 1 bottle of Green.";
            }
            else if (S2)
            {
                texth.GetComponent<Text>().text = "A gun? The piano player had some bullets over there.";
            }
            else if (S3)
            {
                texth.GetComponent<Text>().text = "Yee-haw! Now we can take some compensation from the boss!";
            }
            else if (S4)
            {
                texth.GetComponent<Text>().text = "This is the key to get out of here! Let's go!";
            }
            else
            {
                texth.GetComponent<Text>().text = "How did you get this text?";
            }
        }
    }
    public void SetText(string t)
    {
        Texthold = true;
        texth.GetComponent<Text>().text = t;
    }
    public void flipText()
    {
        Texthold = false;

    }
}
