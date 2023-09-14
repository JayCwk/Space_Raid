using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerPos : MonoBehaviour
{
    // Start is called before the first frame update
    private gameMaster gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<gameMaster>();
        transform.position =gm.lastCheckPoint ;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
