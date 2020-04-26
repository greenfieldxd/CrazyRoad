using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadNextLevel()
    {
        int activeSneneIndex = SceneManager.GetActiveScene().buildIndex; // find index active scene
        SceneManager.LoadScene(activeSneneIndex + 1);
    }

    public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadEndScene()//load last scene
    {
        SceneManager.LoadScene("EndScene");
    }

    public void RestartScene()
    {
        int activeSceneIndex = SceneManager.GetActiveScene().buildIndex; 
        SceneManager.LoadScene(activeSceneIndex); //restart scene
    }

    public void LoadLevel(int indexScene)
    {
        
        SceneManager.LoadScene(indexScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
