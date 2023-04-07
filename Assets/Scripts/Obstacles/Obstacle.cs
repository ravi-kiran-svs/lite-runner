using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    [SerializeField] private Runner.PowerState obsType = Runner.PowerState.LIGHTMAN;

    public Runner.PowerState GetObsType() {
        return obsType;
    }

}
