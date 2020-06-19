using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject nave1;
    public GameObject nave2;
    public int navespawn = 0;
    public float timer = 0;
    public int timertospawn = 5;

    

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timertospawn && navespawn == 1)
        {
            Instantiate(nave1, gameObject.transform);
            timer = 0;
        }
        else if (timer >= timertospawn)
        {
            Instantiate(nave2, gameObject.transform);
            timer = 0;
        }
    }
}
