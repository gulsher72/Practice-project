using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour
{
    // Start is called before the first frame update
    //4- "If Statement in Unity."

     float coffeeTemperature = 80.0f;
     float hotLimitTemperature = 70.0f;
     float coldLimitTempture = 40.0f;

      void Update()
     {
         if (Input.GetKeyDown(KeyCode.Space))
         {
             TemperatureTest();

             coffeeTemperature -= Time.deltaTime * 5f;
         }
     }

     void TemperatureTest()
     {
         if(coffeeTemperature > hotLimitTemperature)
         {
             print("Coffee is too hot");
         }
         else if (coffeeTemperature < coldLimitTempture)
         {
             print("Coffee is to cold.");
         }
         else
         {
             print("Coffee is just right");
         }
     }
}
