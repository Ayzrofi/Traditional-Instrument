using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nada : MonoBehaviour {
    [SerializeField]
    AudioSource Audio;
    [Header("Note Default")]
    public AudioClip NoteDefault;
    [Header("Note A")]
    public AudioClip NoteA;
    [Header("Note B")]
    public AudioClip NoteB;
    [Header("Note C")]
    public AudioClip NoteC;
    [Header("Note A & B")]
    public AudioClip NoteA_B;
    [Header("Note A & C")]
    public AudioClip NoteA_C;
    [Header("Note B & C")]
    public AudioClip NoteB_C;
    [Header("Note ABC")]
    public AudioClip NoteABC;

    void Start () {
        if (Audio == null)
            Audio = FindObjectOfType<AudioSource>();
	}
	

    public void PlaySound()
    {
        if (Audio.isPlaying)
            Audio.Stop();

        //A
            if (Notes.noteA && !Notes.noteB && !Notes.noteC)
        {
            Audio.PlayOneShot(NoteA);
            Debug.Log("A");
        }
        
        //B
            if (Notes.noteB && !Notes.noteA && !Notes.noteC)
        {
            Audio.PlayOneShot(NoteB);
            Debug.Log("B");
        }
        
        //C
            if (Notes.noteC && !Notes.noteA && !Notes.noteB)
        {
            Audio.PlayOneShot(NoteC);
            Debug.Log("C");
        }
        
        // A & B
            if (Notes.noteA && Notes.noteB && !Notes.noteC)
        {
            Audio.PlayOneShot(NoteA_B);
            Debug.Log("A & B");
        }
        
        // A & C
            if (Notes.noteA && Notes.noteC && !Notes.noteB)
        {
            Audio.PlayOneShot(NoteA_C);
            Debug.Log("A & C");
        }
        
        // B & C
            if (Notes.noteB && Notes.noteC && !Notes.noteA)
        {
            Audio.PlayOneShot(NoteB_C);
            Debug.Log("B & C");
        }
        
        // A B C
            if (Notes.noteA && Notes.noteB && Notes.noteC)
        {
            Audio.PlayOneShot(NoteABC);
            Debug.Log("A B C");
        }
        
        // default
        if(!Notes.noteA && !Notes.noteB && !Notes.noteC)
        {
            Audio.PlayOneShot(NoteDefault);
            Debug.Log("njing");
        }
           
    }
}
