using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ToMenu : MonoBehaviour {
    [SerializeField]
    Animator anim;
    private void Start()
    {
        if (anim == null)
            anim = GameObject.Find("Scene Transitions").GetComponent<Animator>();
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            backToMenu();
        }
          
	}

    public void backToMenu()
    {
        StartCoroutine(ToMainMenu());
    }
    IEnumerator ToMainMenu()
    {
        anim.SetTrigger("End");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Main_Menu");
    }
}
