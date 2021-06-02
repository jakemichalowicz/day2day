using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using NotePad;

public class noteColLayer : MonoBehaviour
{

    //public NotePad.OpenNotepadCombined2 notesButton;
    public GameObject button;
    public SpriteRenderer rendColor;
    
    void Start() {
        button = GameObject.Find("NotesButtonCombined 1");
    }
    void Update()
    {
        var opened = button.GetComponent<OpenNotepadCombined2>().OpenNote;
        //OpenNotepadCombined2 temp = button.GetComponent<OpenNotepadCombined2>();
        //temp.tempTest();
        //Debug.Log(opened);
        if (opened%2 == 0) {
            rendColor.sortingOrder = 2;
        } else {
            rendColor.sortingOrder = 0;
        }
    }
}
