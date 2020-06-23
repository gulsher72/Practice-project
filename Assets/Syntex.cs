using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntex : MonoBehaviour
{
    // Start is called before the first frame update
    //3- "Conventions and Syntex in Unity."

    void Start()
    {
        Debug.Log(transform.position.x);
        if(transform.position.y <=5f)
        {
            Debug.Log("I am about to hit the ground");
        }
    }
}
