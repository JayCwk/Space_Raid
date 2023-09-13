using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    private gameMaster gm;
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<gameMaster>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag ("Player"))
        {
            gm.lastCheckPoint = transform.position;
        }
    }
}
