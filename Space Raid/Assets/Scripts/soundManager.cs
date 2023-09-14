using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundManager : MonoBehaviour
{
    public static soundManager instance { get; private set; }
    private AudioSource source;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        source = GetComponent<AudioSource>();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != null && instance != this)
            Destroy(gameObject);
    }

   
    
    public void PlaySound(AudioClip _sound)
    {
        source.PlayOneShot(_sound);
    }
}
