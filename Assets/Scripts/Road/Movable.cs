using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour {

    protected float dOnRoad;
    protected Vector2 pAtBirth;

    protected void Start() {
        dOnRoad = Road.GetDistanceTravelled();
        pAtBirth = transform.position;
    }

    protected void Update() {
        float dByRoad = Road.GetDistanceTravelled() - dOnRoad;

        Vector2 p = pAtBirth - new Vector2(dByRoad, 0);

        transform.position = p;
    }

}
