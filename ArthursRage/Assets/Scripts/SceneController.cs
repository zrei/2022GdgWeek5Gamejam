using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public void PlayButton() {
        SceneManager.LoadScene(1);
    }

    public void ReplayButton() {
        SceneManager.LoadScene(1);
    }

    public void MainMenuButton() {
        SceneManager.LoadScene(0);
    }
}
