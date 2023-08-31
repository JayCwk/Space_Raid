using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEditorScript1 : MonoBehaviour
{
    public GameObject down;
    public Transform bulletPos;

    private float timer;
    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2)
        {
            timer = 0;
            shoot();

        }
    }

    void shoot()
    {
        Instantiate(down, bulletPos.position, Quaternion.identity);
    }
}
