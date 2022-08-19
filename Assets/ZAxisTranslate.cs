using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZAxisTranslate : MonoBehaviour
{
    private float start = 5;
    private float end = -5;
    float dir = 1f;
    
    

    // Update is called once per frame
    void Update()
    {   
        if (transform.position.z >= start) {
            dir = -1.0f;
        }
        else if (transform.position.z <= end) {
            dir = 1.0f;
        } 
        this.transform.localPosition += new Vector3(0.0f, 0.0f, dir*0.005f);
    }
}
