using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMenu;
   


    private void Disenable()
    {
       
    }

    public void EnableGameOverMenu()
    {
        gameOverMenu.SetActive(true);
       
    }
}
