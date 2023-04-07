using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public void OnPauseButtonPressed() {
        Time.timeScale = 0;
        gameObject.SetActive(true);
    }

    public void OnResumeButtonPressed() {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
