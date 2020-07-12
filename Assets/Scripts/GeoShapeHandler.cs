using System;
using UnityEngine;

public class GeoShapeHandler : MonoBehaviour
{
    private bool canAddScore;

    private void Start()
    {
        canAddScore = true;
        EventHandler.OnInvokeCollider -= AddScoreOnce;
        EventHandler.OnInvokeCollider += AddScoreOnce;
    }

    private void AddScoreOnce()
    {
        if(!canAddScore) return;
        EventHandler.InvokeScore(1);
        canAddScore = false;
    }

    private void OnDisable()
    { 
        EventHandler.OnInvokeCollider -= AddScoreOnce;
    }
}