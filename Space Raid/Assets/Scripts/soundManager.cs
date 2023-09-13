using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundManager : MonoBehaviour
{
    public static soundManager instance { get; private set; }
    private AudioSource source;
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            load();
        }
        else
        {
            load();
        }

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

    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        save();
    }


    private void load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicvolume");
    }

    private void save()
    {
        PlayerPrefs.SetFloat("musicvolume", volumeSlider.value);
    }
    
    public void PlaySound(AudioClip _sound)
    {
        source.PlayOneShot(_sound);
    }
}
