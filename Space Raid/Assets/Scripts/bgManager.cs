using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bgManager : MonoBehaviour
{
    private AudioSource source;
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            load();
        }
        else
        {
            load();
        }
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


}
