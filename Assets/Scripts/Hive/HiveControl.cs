using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveControl : MonoBehaviour
{
    public Vector3 mousePosition;
    // Update is called once per frame
    void Update()
    {
        // Get the current mouse position in screen coordinates
        Vector3 mousePosition = Input.mousePosition;

        // Convert the mouse position from screen space to world space
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Update the object's position to the mouse position

        GetComponent<Rigidbody2D>().position = (Vector2)mousePosition;
    }
}
