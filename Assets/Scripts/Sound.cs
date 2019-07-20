using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public static Sound Instance = null;

    public AudioClip beep;
    public AudioClip crash;
   //public AudioClip hailing;
    public AudioClip PoliceSiren;
    private AudioSource soundAudio;


    // Use this for initialization
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != null)
        {
            Destroy(gameObject);
        }
        AudioSource theSource = GetComponent<AudioSource>();
        soundAudio = theSource;
    }


    public void PlayOneShot(AudioClip clip)
    {
        soundAudio.PlayOneShot (beep);
        soundAudio.PlayOneShot(crash);
        soundAudio.PlayOneShot(PoliceSiren);

    }
}
