using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Vector3 mousePosition;

    // Adjust this value to control how smoothly the object follows the mouse
    public float followSpeed = 10f;

    void Update()
    {
        // Get the mouse position in world space
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Set the Z position of the mouse position to match the object's Z position
        mousePosition.z = transform.position.z;

        // Smoothly lerp the object's position towards the mouse position
        transform.position = Vector3.Lerp(transform.position, mousePosition, followSpeed * Time.deltaTime);
    }
}