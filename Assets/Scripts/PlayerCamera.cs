using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;
    [SerializeField]
    private float xSens = 30f, ySens = 30f;
    
    public void MoveCamera(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        // Calculate cam rotation for up/down
        xRotation  -= (mouseY * Time.deltaTime) * ySens;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        // Apply to camera's transform
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        // Rotate player object left/right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSens);
    }
}
