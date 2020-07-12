using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private Camera currentCamera;
    private bool targetJoint;
    private Mover mover;
    private Vector2 localHitPoint = Vector2.zero;
    private void Awake()
    {
        currentCamera = Camera.main;
    }
    
    private void Update()
    {
        Press();
        Relase();
        
        if(mover == null) return;
        mover.EnableMove(targetJoint, localHitPoint);
    }

    private void Press()
    {
        if (!Input.GetButtonDown("Fire1")) return;
        var ray = currentCamera.ScreenToWorldPoint(Input.mousePosition);
        var dir = Vector2.zero;
        var hit = Physics2D.Raycast(ray, dir);
        if (!hit) return;
        localHitPoint = hit.transform.InverseTransformPoint(hit.point);
        mover = hit.collider.GetComponent<Mover>();
        targetJoint = true;
    }

    private void Relase()
    {
        if (!Input.GetButtonUp("Fire1")) return;
        targetJoint = false;
        localHitPoint = Vector3.zero;
    }

    private void FixedUpdate()
    {
        var mousePoition = currentCamera.ScreenToWorldPoint(Input.mousePosition);
        if(mover == null) return;
        mover.Move(mousePoition);
    }
}
