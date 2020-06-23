using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    // Start is called before the first frame update

    public int apples;
    public int bannas;

    private int mango;
    private int graphes;

    public void FruitMachine( int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total; + answer");

    }

    private void OfficerSort(int a, int b)
    {

        int answer;
        answer = a + b;
        Debug.Log("Officer Supplies Total; + answer");

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
