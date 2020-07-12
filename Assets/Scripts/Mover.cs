using System;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private TargetJoint2D targetJoint;
    private void Awake()
    {
        targetJoint = GetComponent<TargetJoint2D>();
    }

    private void Start()
    {
        targetJoint.enabled = false;
    }

    public void EnableMove(bool targetJointEnable, Vector2 pos)
    {
        targetJoint.enabled = targetJointEnable;
        targetJoint.anchor = pos;
    }

    public void Move(Vector3 pos)
    {
        if (targetJoint.enabled)
        {
            targetJoint.target = pos;
        }
    }
}

