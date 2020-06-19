using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveMovement : MonoBehaviour
{
    public int speed = 10;
    public int timetodestroy = 5;
    public float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timetodestroy)
        {
            Destroy(gameObject);
        }
        transform.position += transform.right * Time.deltaTime * speed;
    }
}
