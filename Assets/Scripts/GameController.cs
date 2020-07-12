using System;
using UnityEngine;
using  UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    private void Start()
    {
        EventHandler.OnInvokeTimeOut -= GameOver;
        EventHandler.OnInvokeTimeOut += GameOver;
    }

    private void GameOver()
    {
        SceneManager.LoadSceneAsync(2);
    }

    private void OnDisable()
    {
        EventHandler.OnInvokeTimeOut -= GameOver;
    }
}