using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject flashlightUI;
    public Button resumeButton;
    public Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        if(Input.GetKey(KeyCode.F))
        {
            flashlightUI.SetActive(false);
        }
        pauseMenu.SetActive(false);
        resumeButton.onClick.AddListener(OnResumePressed);
        quitButton.onClick.AddListener(OnQuitPressed);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

    void OnResumePressed()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    void OnQuitPressed()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
