using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{

    string path = "";

    [SerializeField] private Button continueButton;

    void Awake()
    {
        SetPaths();

    
    }

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;

        Time.timeScale = 1f;


        // Search for Saved Game 
        // If not found then disable continue
        if (!System.IO.File.Exists(path))
            continueButton.interactable = false;
        else
            continueButton.interactable = true;
    }


    private void SetPaths()
    {
        path = Application.persistentDataPath + "/savaData.json";
    }

    public void ExitGame ()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false; // Unity Editor Only
    }
    

}
