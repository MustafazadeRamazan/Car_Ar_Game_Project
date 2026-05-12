using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource SesKaynak;
    public AudioClip cashSound;
    public AudioClip knopqa;
    public AudioClip zbutton;

    void Start()
    {
        SesKaynak = GetComponent<AudioSource>();
    }

    public void PlaySound (string clip)
    {
        switch (clip) {
            case "cashsound":
                SesKaynak.PlayOneShot(cashSound);
                break;
            case "knopqa":
                SesKaynak.PlayOneShot(knopqa);
                break;
            case "zbutton":
                SesKaynak.PlayOneShot(zbutton);
                break;

        }

    }

    
    
}
