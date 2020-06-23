using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Start is called before the first frame update

 
    // Update is called once per frame
    // 1- "Scripts and Behaviour Components in Unity."
     void Update()
     {
         if(Input.GetKeyDown(KeyCode.Space))
         {
            GetComponent<Renderer>().material.color = Random.ColorHSV();
         }
         if(Input.GetKeyDown(KeyCode.B))
         {
             GetComponent<Renderer>().material.color = Color.blue;
         }
         if(Input.GetKeyDown(KeyCode.G))
         {
             GetComponent<Renderer>().material.color = Color.green;
         }
     }

    

    


    
     

    


}

