using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOption : MonoBehaviour
{
    public Rigidbody2D targetGravityScl; 
    public Transform targetSizeScl;
    public Rigidbody2D targetTimeScl;
    public float gravityMultiplier = 0.4f; // Multiplier to adjust the gravity scale
    public float sizeMultiplier = 0.4f; // Multiplier to adjust the gravity scale

    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (targetGravityScl != null)
        {
            float targetY = targetGravityScl.position.y;
            rb.gravityScale = Mathf.Clamp(targetY * gravityMultiplier, 0f, Mathf.Infinity);
            
        }
        if (targetSizeScl != null)
        {
            float targetY = targetSizeScl.position.y;
            float newSize = Mathf.Clamp(targetY * sizeMultiplier, 0f, Mathf.Infinity);
            transform.localScale = new Vector3(newSize, newSize, newSize);
        }
    }
}
