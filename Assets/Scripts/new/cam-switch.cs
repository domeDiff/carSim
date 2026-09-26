using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    [Header("PRESS C TO CHANGE CAM")]
    public Camera camera1;
    public Camera camera2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }
    }
}