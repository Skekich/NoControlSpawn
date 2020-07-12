using System;
using UnityEngine;
using  TMPro;
public class TimeScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textTime;
    [SerializeField] private float initialTime;

    private float currentTime = 0f;

    private void Start()
    {
        currentTime = initialTime;
        textTime.text = $"Time left {currentTime}";
    }

    private void Update()
    {
        TimeCalculation();
    }

    private void TimeCalculation()
    {
        if (currentTime <= 0)
        {
            EventHandler.InvokeTimeOut();
            return;
        }

        currentTime -= Time.deltaTime;
        textTime.text = $"Time left {currentTime:0}";
    }
}