using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject flashlightUI;
    public Button resumeButton;
    public Button quitButton;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        resumeButton.onClick.AddListener(onResumePressed);
        quitButton.onClick.AddListener(onQuitPressed);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        
        if(flashlightUI == true && Input.GetKey(KeyCode.F))
        {
            flashlightUI.SetActive(false);
        }
    }

    void onResumePressed()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    void onQuitPressed()
    {
        SceneManager.LoadScene("menuUi");
    }
}
