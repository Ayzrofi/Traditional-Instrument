using UnityEngine;
using UnityEngine.UI;


public class PlayMusic : MonoBehaviour {
    [SerializeField]
    private AudioSource audioSrc;

    private bool isPlaying = false;
    [SerializeField]
    Image Img;
    [SerializeField]
    Color32 colorPlay,colorDefault;



    private void Awake()
    {
        if (audioSrc == null)
            audioSrc = FindObjectOfType<AudioSource>();

        if (Img == null)
            Img = GetComponent<Image>();
    }

    public void PlaySound(AudioClip Clip)
    {
        isPlaying = !isPlaying;

        if (isPlaying )
        {
            audioSrc.Stop();
            audioSrc.PlayOneShot(Clip);
            Img.color = colorPlay;
            ResetPlaylist();
        }
        else if (!isPlaying)
        {
            audioSrc.Stop();
            Img.color = colorDefault;
        }
    }
    // membuat semua boolean IsPlaying pada selain Button yg ngePlay Audio menjadi false 
    // agar tidak ada serangga yang mengganggu
    void ResetPlaylist()
    {
        PlayMusic[] Pm = FindObjectsOfType<PlayMusic>();
        foreach (var Sound in Pm)
        {
            if (Sound.gameObject != this.gameObject)
            {
                Sound.isPlaying = false;
                Sound.Img.color = colorDefault;
            }
        }
    }
}
