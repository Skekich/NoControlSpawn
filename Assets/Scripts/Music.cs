using System;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        audioSource.loop = true;
        audioSource.playOnAwake = true;
        audioSource.Play();
        DontDestroyOnLoad(this);
    }
}