using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void OnStartButtonPressed() {
        SceneManager.LoadScene(1);
    }

}
