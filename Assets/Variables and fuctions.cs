using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variablesandfuctions : MonoBehaviour
{
    // Start is called before the first frame update

    //2- "Variable and Functions in Unity"

     int myInt = 5;
     void Start()
     {
         myInt = MultiByTwo(myInt);
         Debug.Log(myInt);
     }
     int MultiByTwo(int number)
     {
         int result;
         result = number * 2;
         return result;

     }
}
