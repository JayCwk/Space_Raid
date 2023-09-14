using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour
{
    private void Start()
    {

    }

    private void Update()
    {

    }

    public void LoaDGame()
    {
        SceneManager.LoadScene("tutorial level");
    }

}
