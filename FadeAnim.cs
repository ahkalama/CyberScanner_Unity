using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAnim : MonoBehaviour
{
    private bool CameraActive = false;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (CameraActive == false)
            {
                anim.SetBool("fade", true);
                CameraActive = true;
            }
            else
            {
                anim.SetBool("fade", false);
                CameraActive = false;
            }
        }
    }
}
