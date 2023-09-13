using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour
{
    // Start is called before the first frame update
    private static gameMaster instance;
    public Vector2 lastCheckPoint;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
