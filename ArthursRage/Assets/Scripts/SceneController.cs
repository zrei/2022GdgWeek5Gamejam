using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public void PlayButton() {
        SceneManager.LoadScene(1);
    }
}
