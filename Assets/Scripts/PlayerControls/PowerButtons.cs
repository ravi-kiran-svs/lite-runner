using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerButtons : MonoBehaviour {

    [SerializeField] private Runner runner;

    public void OnPowerButtonPressed(int i) {
        runner.ChangePowerState((Runner.PowerState)i);
        /*switch (i) {
            case 0:
                runner.ChangePowerState(0);
                break;
        }*/
    }

}
