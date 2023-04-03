using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour {
    [SerializeField] private Road road;
    private TMP_Text text;

    private void Awake() {
        text = GetComponent<TMP_Text>();
    }

    private void Update() {
        text.text = road.getDistanceTravelled().ToString("0.00");
    }
}
