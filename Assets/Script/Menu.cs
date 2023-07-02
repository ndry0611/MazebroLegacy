using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button btnStart;
    public Button btnQuit;

    // Start is called before the first frame update
    void Start()
    {
        btnStart.onClick.AddListener(StartGame);
        btnQuit.onClick.AddListener(QuitGame);
        
    }

    void StartGame()
    {
        SceneManager.LoadScene("level1");
    }

    void QuitGame()
    {
        //For Build
        //Application.Quit();

        //For Editor
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
