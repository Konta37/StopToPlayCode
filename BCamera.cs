using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCamera : MonoBehaviour
{
    public Transform targetObject; // Transform of the object whose Y-axis position controls the camera size
    public float minY = 5f; // Minimum orthographic size
    public float maxY = 10f; // Maximum orthographic size
    public float sizeMultiplier = 1f; // Multiplier to adjust the size

    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }

    private void Update()
    {
        if (targetObject != null)
        {
            float targetY = targetObject.position.y;
            float newSize = Mathf.Clamp(targetY * sizeMultiplier, 0f, Mathf.Infinity);
            cam.orthographicSize = newSize;
        }
    }
}
