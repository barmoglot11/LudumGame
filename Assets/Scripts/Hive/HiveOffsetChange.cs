using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiveOffsetChange : MonoBehaviour
{
    [SerializeField] KeyCode hiveOffsetSmaller = KeyCode.Q;
    [SerializeField] KeyCode hiveOffsetBigger = KeyCode.E;

    public RelativeJoint2D Joint => GetComponent<RelativeJoint2D>();
    public Vector2 offset;

    [SerializeField] float changeOffset = 1f;

    private void Update()
    {
        if (Input.GetKeyDown(hiveOffsetSmaller))
        {
            Joint.linearOffset = new(0,0);
        }
        if (Input.GetKeyUp(hiveOffsetSmaller))
        {
            Joint.linearOffset = offset;
        }

        if (Input.GetKeyDown(hiveOffsetBigger))
        {
            Joint.linearOffset = new(offset.x + changeOffset, offset.y + changeOffset);
        }
        if (Input.GetKeyUp(hiveOffsetBigger))
        {
            Joint.linearOffset = offset;
        }

    }
}
