using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RunnerCollisions : MonoBehaviour {

    public UnityEvent RunnerDead;

    private Runner runner;

    private void Awake() {
        runner = GetComponent<Runner>();
    }

    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.GetComponent<Obstacle>().GetObsType() != runner.GetPowerState()) {
            RunnerDead.Invoke();
        }
    }

}
