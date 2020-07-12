using System;
using UnityEngine;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score;
    private void Start()
    {
        score = 0;
        scoreText.text = $"Score: {score}";
        EventHandler.OnInvokeScore -= AddScore;
        EventHandler.OnInvokeScore += AddScore;
    }

    private void AddScore(int obj)
    {
        score += obj;
        scoreText.text = $"Score: {score}";
    }

    private void OnDisable()
    {
        EventHandler.OnInvokeScore -= AddScore;
    }
}