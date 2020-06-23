using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject myobject;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            myobject.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            myobject.SetActive(false);
        }

    }
}
