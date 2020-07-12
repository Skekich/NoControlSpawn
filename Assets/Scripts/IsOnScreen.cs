using System;
using UnityEngine;

public class IsOnScreen : MonoBehaviour
{
    private Camera currnetCamera;
    private Vector2 currentScreenSize;
    private const int score = -1;
    private SpriteRenderer spRend;
    
    private void Awake()
    {
        currnetCamera = Camera.main;
        spRend = GetComponent<SpriteRenderer>();
    }
    
    private void Update()
    {
        if(!IsOutOfScreen()) return;
        if(spRend.color != Color.green) return;
        EventHandler.InvokeScore(score);
        Destroy(gameObject);
    }

    private bool IsOutOfScreen()
    {
        currentScreenSize = currnetCamera.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        return Mathf.Abs(transform.position.x) > currentScreenSize.x;
    }
}