using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class SceneManajer : MonoBehaviour {
    [SerializeField]
    Animator Anim;
    [SerializeField]
    AudioSource AudioSrc;
    private void Start()
    {
        if (Anim == null)
            Anim = FindObjectOfType<Animator>();

        if (AudioSrc == null)
            AudioSrc = GetComponent<AudioSource>();
    }
    public void PlaySoundEffect(AudioClip clip)
    {
        AudioSrc.PlayOneShot(clip);
    }
    public void LoadScene(string SceneName)
    {
        StartCoroutine(TimeLoadScene(SceneName));
    }

    IEnumerator TimeLoadScene(string Scene)
    {
        Anim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(Scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}// End Of Class
