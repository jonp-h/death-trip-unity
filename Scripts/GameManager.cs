using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject completeLevelUI;
    public void EndGame() {
        Debug.Log("Game over");
        Invoke("Restart", 2f);
        
    }

// test 2
    public void CompleteLevel() {
        Debug.Log("compelete");
        completeLevelUI.SetActive(true);
    }

    public void LoadNextLevel() {
        // Invoke("LoadNextLevel", 2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void quit() {
        Debug.Log("quit");
        Application.Quit();
    }

}
