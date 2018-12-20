using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PantingBasic : MonoBehaviour {
    [SerializeField]
    AudioSource Audio;
    [SerializeField]
    Image img;

    void Start()
    {
        if (Audio == null)
            Audio = FindObjectOfType<AudioSource>();
        if (img == null)
            img = GetComponent<Image>();
    }

    public void PlaySound(AudioClip Suara)
    {
        if (Audio.isPlaying)
            Audio.Stop();

        img.color = new Color32(255, 255, 255, 70);
        Audio.PlayOneShot(Suara);
    }

    public void StopPlayingSound()
    {
        img.color = new Color32(255, 255, 255, 255);
    }
}
