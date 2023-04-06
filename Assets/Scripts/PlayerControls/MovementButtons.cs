using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementButtons : MonoBehaviour {

    [SerializeField] private Runner runner;

    public void OnMovementButtonPressed(int i) {
        runner.ChangeLane(i);
        /*switch (i) {
            case 0:
                runner.ChangeLane(-1);
                break;
        }*/
    }
}
