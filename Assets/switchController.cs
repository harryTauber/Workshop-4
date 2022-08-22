using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchController : MonoBehaviour
{
    private accelerate accelerate;
    private XZ_Input xzInput;

    [SerializeField] private Material movementMaterial;
    [SerializeField] private Material accelerationMaterial;
    private MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        accelerate = gameObject.GetComponent<accelerate>();
        accelerate.enabled = false;
        xzInput = gameObject.GetComponent<XZ_Input>();
        xzInput.enabled = true;

        this.meshRenderer = gameObject.GetComponent<MeshRenderer>();
        this.meshRenderer.material = this.movementMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            if (accelerate.enabled==true) {
                accelerate.enabled = false;
                xzInput.enabled = true;
                meshRenderer.material = movementMaterial;
            } else {
                accelerate.enabled = true;
                xzInput.enabled = false;
                meshRenderer.material = accelerationMaterial;
            }
        }
    }
}
