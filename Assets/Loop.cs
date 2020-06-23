using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    //5- Loops

    int cupInTheSink = 5;
    void Start()
    {
        while(cupInTheSink > 0)
        {
            Debug.Log(" I have washed a cup");
            cupInTheSink--;

        }

        bool shouldCont = false;
        do
        {
            print(" Hello world");
        }
        while (shouldCont == true);

        int number = 4;

        for( int i =0; i < number; i ++)
        {
            Debug.Log("Creating enemy number");
        }
    }

}
