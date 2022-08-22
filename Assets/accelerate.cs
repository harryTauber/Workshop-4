using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerate : MonoBehaviour
{
    private float vx = 0.0f, vz = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
             vx -= 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            vx += 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            vz += 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            vz -= 1.0f;
        }
        this.transform.localPosition += new Vector3(vx,0.0f,vz)*Time.deltaTime;
    }
}
