using System.Collections;
using UnityEngine;

public class ThermalCameraToggle : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject thermalCamera;
    private bool isThermalCameraActive = false;

    public float transitionDelay = 0.1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isThermalCameraActive == false)
            {
                audioSource.Play();
                StartCoroutine(ToggleThermalCameraWithDelay());
            }
            else
            {
                audioSource.Stop();
                StartCoroutine(ToggleThermalCameraWithDelay());
            }
        }
    }

    IEnumerator ToggleThermalCameraWithDelay()
    {
        yield return new WaitForSeconds(transitionDelay);

        isThermalCameraActive = !isThermalCameraActive;
        thermalCamera.SetActive(isThermalCameraActive);
    }
}
