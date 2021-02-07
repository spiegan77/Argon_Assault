using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // This is required for loading scenes

public class MusicPlayer : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject); //gameObject is the "thing" the script is attached to
    }
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
