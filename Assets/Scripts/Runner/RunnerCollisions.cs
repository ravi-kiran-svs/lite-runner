using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RunnerCollisions : MonoBehaviour {

    // only for testing
    [SerializeField] private bool isImmortal = false;

    public UnityEvent RunnerDead;

    private Runner runner;

    private void Awake() {
        runner = GetComponent<Runner>();
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if (!isImmortal) {
            if (collider.GetComponent<Obstacle>().GetObsType() != runner.GetPowerState()) {
                RunnerDead.Invoke();
            }
        }
    }

}
