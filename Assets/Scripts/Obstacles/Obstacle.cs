using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    [SerializeField] private Runner.PowerState obsType = Runner.PowerState.LIGHTMAN;

    private void OnTriggerEnter2D(Collider2D collider) {
        if (collider.GetComponent<Runner>().GetPowerState() != obsType) {
            Debug.Log(collider.GetComponent<Runner>().GetPowerState());
            Debug.Log("DEATH");
        }
    }

    public Runner.PowerState GetObsType() {
        return obsType;
    }

}
