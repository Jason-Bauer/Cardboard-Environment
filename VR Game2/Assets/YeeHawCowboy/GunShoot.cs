using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
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

    public void Shoot()
    {
        if (manager.GetComponent<PuzzleManager>().hasBullets) {
            GetComponent<Animation>().Play();
            GetComponentInChildren<ParticleSystem>().Play();
        }
    }
}
