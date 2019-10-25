using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour {

	
    void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    void ExitGame()
    {
        SceneManager.LoadScene("Exit");
    }

    void MainMenu()
    {
        SceneManager.LoadScene("Intro");
    }

}
