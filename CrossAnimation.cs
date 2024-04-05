using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimation : MonoBehaviour
{
    private bool ThermalCameraActive = false;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (ThermalCameraActive == false)
            {
                anim.SetBool("Thermalcam", true);
                ThermalCameraActive = true;
            }
            else
            {
                anim.SetBool("Thermalcam", false);
                ThermalCameraActive = false;
            }
        }
    }
}
