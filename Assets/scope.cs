using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scope : MonoBehaviour
{

    // Start is called before the first frame update
    public int alpha = 5;
    private int beta = 0;
    private int gamme = 5;

    private AnotherClass myclass;
    void Start()
    {
        alpha = 25;
        myclass = new AnotherClass();
        myclass.FruitMachine(alpha, myclass.apples);
    }

    void Example(int pen, int crayons)
    {
        int answer;
        answer = pen * crayons * alpha;
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to:" + alpha);
    }
}

