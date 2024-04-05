using UnityEngine;

public class ThermalCam : MonoBehaviour
{
    public float maxZoomDistance = 10f;
    public float minZoomDistance = 1f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
            ZoomCamera();
        else
            ZoomOut();
    }

    void ZoomCamera()
    {
        float newFOV = CalculateFOV(5);
        Camera.main.fieldOfView = newFOV;
    }

    void ZoomOut()
    {
        float newFOV = CalculateFOV(0);
        Camera.main.fieldOfView = newFOV;
    }

    float CalculateFOV(float distance)
    {
        return Mathf.Lerp(60f, 30f, Mathf.InverseLerp(minZoomDistance, maxZoomDistance, distance));
    }
 
}
