using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseObjectMove : MonoBehaviour
{
    public float minY = 2.5f; // Minimum Y-axis position
    public float maxY = 8f; // Maximum Y-axis position
    public float moveSpeed = 5f; // Speed of movement

    private Vector3 targetPosition;
    private bool isDragging = false;

    private void OnMouseDown()
    {
        isDragging = true;
        targetPosition = transform.position;
    }

    private void OnMouseDrag()
    {
        float mouseY = Input.mousePosition.y;
        float newY = Mathf.Clamp(Camera.main.ScreenToWorldPoint(new Vector3(0, mouseY, 0)).y, minY, maxY);
        targetPosition = new Vector3(transform.position.x, newY, transform.position.z);
    }

    private void Update()
    {
        if (isDragging)
        {
            // Move the object towards the target position
            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }
}
