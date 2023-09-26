using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{
    public float delayInSeconds = 14f; // Adjust this value to set the delay in seconds

    private void Start()
    {
        // Call the LoadScene method with a delay
        Invoke("LoadNextScene", delayInSeconds);
    }

    private void LoadNextScene()
    {
        // Load the next scene by name
        SceneManager.LoadScene("tutorial level"); 
    }
}
