using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumPanel : MonoBehaviour
{
    public Queue<int> combo=new Queue<int>();
    public GameObject door;
    public Light an;
    // Start is called before the first frame update
    void Start()
    {
        door.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void add(int num)
    {
        combo.Enqueue(num);
        Debug.Log(num);
    }
    public void clear()
    {
        combo.Clear();
    }
    public void check()
    {
        int a = combo.Dequeue();
        if (a == 8)
        {
            a = combo.Dequeue();
            if (a == 6)
            {
                a = combo.Dequeue();
                if (a == 7)
                {
                    a = combo.Dequeue();
                    if (a == 5)
                    {
                        a = combo.Dequeue();
                        if (a == 3)
                        {
                            a = combo.Dequeue();
                            if (a == 0)
                            {
                                a = combo.Dequeue();
                                if (a == 9)
                                {
                                    an.color = Color.green;
                                    door.GetComponent<BoxCollider>().enabled = true;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
