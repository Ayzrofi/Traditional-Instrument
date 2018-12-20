
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoSceneManajer : MonoBehaviour {
    [SerializeField]
    VideoPlayer Vp;
   
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Vp.Stop();
            SceneManager.LoadScene("Main_Menu");
        }
    }

}
