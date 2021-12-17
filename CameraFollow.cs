using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;

    public int camera =1;

    private void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camera += 1;

            if (camera > 3)
            {
                camera = 1;
            }
        }

        if (camera == 1)
        {
            cam1.enabled = true;
            cam2.enabled = false;
            cam3.enabled = false;
        }
        
        if (camera == 2)
        {
            cam1.enabled = false;
            cam2.enabled = true;
            cam3.enabled = false;
        }
        if (camera == 3)
        {
            cam1.enabled = false;
            cam2.enabled = false;
            cam3.enabled = true; 
        }
    }
}