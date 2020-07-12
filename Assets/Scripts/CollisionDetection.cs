using System;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] private Transform bottom;

    private SpriteRenderer spRed;

    private void Awake()
    {
        spRed = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(!(other.collider.CompareTag("geometry"))) return;
        spRed.color = Color.green;
        EventHandler.InvokeCollide();
    }
    
}