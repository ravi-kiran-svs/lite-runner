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
        // change it to 1 later
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

}
