using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioClip bgmClip; // Reference to the background music audio clip

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Check if the audio clip is set
        if (bgmClip != null)
        {
            audioSource.clip = bgmClip;
            audioSource.loop = true; // Set to loop the BGM
            audioSource.Play(); // Play the background music
        }
        else
        {
            Debug.LogWarning("BGM clip is not assigned to the AudioManager.");
        }
    }
}
