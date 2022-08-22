using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XZ_Input : MonoBehaviour
{
    [SerializeField] private float increment;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float dx = 0.0f, dz = 0.0f;
        if (Input.GetKey(KeyCode.LeftArrow)) {
             dx -= 1.0f;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            dx += 1.0f;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            dz += 1.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            dz -= 1.0f;
        }


        this.transform.localPosition += new Vector3(dx, 0.0f, dz)*increment*Time.deltaTime;
     }
}
