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
        completeLevelUI.SetActive(true);
    }

// test
    public void CompleteLevel() {
        Debug.Log("compelete");
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
