using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPopup : MonoBehaviour
{
    public void PlayAgain() {
        SceneManager.LoadScene(1);
    }

    public void Exit() {
        SceneManager.LoadScene(0);
    }
}
