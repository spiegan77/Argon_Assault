using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // This is required for loading scenes

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadFirstScene", 2f); // Load first scene after 2 seconds
    }
    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
