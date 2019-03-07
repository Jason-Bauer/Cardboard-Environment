using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceManager : MonoBehaviour
{
    public bool complete;
    public GameObject compScreen;
    public GameObject interact1;
    public GameObject interact2;
    public GameObject interact3;
    public GameObject interact4;

    public GameObject zodiacAries;
    public GameObject zodiacTaurus;
    public GameObject zodiacGemini;
    public GameObject zodiacCancer;
    public GameObject zodiacLeo;
    public GameObject zodiacVirgo;
    public GameObject zodiacLibra;
    public GameObject zodiacScorpio;
    public GameObject zodiacSagittarius;
    public GameObject zodiacCapricorn;
    public GameObject zodiacAquarius;
    public GameObject zodiacPisces;

    public Material alienNum;
    public Material alienAlpha;

    public int actCounter1;
    public int actCounter2;
    public int actCounter3;
    public int actCounter4;
    public int lastPressed;
    public int correctNum;

    // Start is called before the first frame update
    void Start()
    {
        complete = false;
        actCounter1 = 0;
        actCounter2 = 0;
        actCounter3 = 0;
        actCounter4 = 0;
        lastPressed = -1;
        correctNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void ExitLevel()
    {
        if(complete)
        {
            SceneManager.LoadScene(sceneBuildIndex: 1);
        }
    }

    void CheckCounters()
    {
        if(actCounter1 == 7 && actCounter2 == 5
            && actCounter3 == 3 && actCounter4 == 1)
        {
            compScreen.GetComponent<Renderer>().material = alienAlpha;
        }
    }

    public void ClickedAct1()
    {
        actCounter1++;

        CheckCounters();
    }

    public void ClickedAct2()
    {
        actCounter2++;

        CheckCounters();
    }

    public void ClickedAct3()
    {
        actCounter3++;

        CheckCounters();
    }

    public void ClickedAct4()
    {
        actCounter4++;

        CheckCounters();
    }

    public void Reset1() { actCounter1 = 0; }
    public void Reset2() { actCounter2 = 0; }
    public void Reset3() { actCounter3 = 0; }
    public void Reset4() { actCounter4 = 0; }

    public void ZodiacPress(int pb)
    {
        switch(pb)
        {
            case 1: lastPressed = 1;
                    correctNum++;
                break;
            case 2:
                if (lastPressed == 1 && correctNum == 1)
                {
                    correctNum++;
                    lastPressed = 2;
                }
                else
                {
                    correctNum = 0;
                    lastPressed = -1;
                }
                break;
            case 3:
                if (lastPressed == 2 && correctNum == 2)
                {
                    correctNum++;
                    lastPressed = 3;
                }
                else
                {
                    correctNum = 0;
                    lastPressed = -1;
                }
                break;
            case 4:
                if (lastPressed == 3 && correctNum == 3)
                {
                    complete = true;
                }
                else
                {
                    correctNum = 0;
                    lastPressed = -1;
                }
                break;
            default:
                correctNum = 0;
                lastPressed = -1;
                break;
        }
    }
}
