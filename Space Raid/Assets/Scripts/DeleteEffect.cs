using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteEffect : MonoBehaviour
{
    void Update()
    {
        Destroy(gameObject, 3f);
    }
}
