using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");


        print(z);
        gameObject.transform.Translate(Vector3.forward * speed* z);
        gameObject.transform.Translate(Vector3.right * speed* x);
        
    }
}
