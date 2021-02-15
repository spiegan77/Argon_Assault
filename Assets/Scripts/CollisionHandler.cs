using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // ok as this is the only script that loads scenes

public class CollisionHandler : MonoBehaviour
{
    [Tooltip("In Seconds")] [SerializeField] float levelLoadDelay = 1f;
    [Tooltip("Particle Effects Prefab On Player")] [SerializeField] GameObject deathFX;


    private void OnTriggerEnter(Collider other)
    {
        StartDeathSequence();
        deathFX.SetActive(true);
        Invoke("ReloadScene" , levelLoadDelay);
    }

    private void StartDeathSequence()
    {
        SendMessage("Fuck_you_shithead");
    }

    private void ReloadScene() // string reference
    {
        SceneManager.LoadScene(1);
    }
}
