using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notes : MonoBehaviour {

    public static bool noteA, noteB, noteC;

    public void PlayNoteA(GameObject Img)
    {
        noteA = true;
        Img.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
        Debug.Log(noteA);
    }

    public void StopPlayNoteA(GameObject Img)
    {
        noteA = false;
        Img.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        Debug.Log(noteA);
    }

    public void PlayNoteB(GameObject Img)
    {
        noteB = true;
        Img.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
    }

    public void StopPlayNoteB(GameObject Img)
    {
        noteB = false;
        Img.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }

    public void PlayNoteC(GameObject Img)
    {
        noteC = true;
        Img.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
    }

    public void StopPlayNoteC(GameObject Img)
    {
        noteC = false;
        Img.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
    }
}
