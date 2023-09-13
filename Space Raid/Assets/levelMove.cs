using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class levelMove : MonoBehaviour
{
    public int sceneBuilder;

    private void OnTriggerEnter2D(Collider2D pther)
    {
        print("Trigger enterred");

        if(pther.tag == "Player")
        {
            print("Switching scene to" + sceneBuilder);
            SceneManager.LoadScene(sceneBuilder, LoadSceneMode.Single);
        }
    }

}
