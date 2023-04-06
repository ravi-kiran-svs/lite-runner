using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour {
    private TMP_Text text;

    private void Awake() {
        text = GetComponent<TMP_Text>();
    }

    private void Update() {
        text.text = Road.GetDistanceTravelled().ToString("0.00");
    }
}
