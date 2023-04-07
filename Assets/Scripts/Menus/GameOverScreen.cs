using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour {

    public void OnRunnerDead() {
        Time.timeScale = 0;
        gameObject.SetActive(true);
    }

    public void OnReplayPressed() {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

}
