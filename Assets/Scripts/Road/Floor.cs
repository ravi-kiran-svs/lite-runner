using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : Movable {

    [SerializeField] Transform rainbowRoad;

    private void Update() {
        float dByRoad = Road.GetDistanceTravelled() - dOnRoad;

        float distance = dByRoad - pAtBirth.x;

        SetMaterialsDistance(distance);
    }

    private void SetMaterialsDistance(float d) {
        for (int i = 0; i < rainbowRoad.childCount; i++) {
            float delta = 0.66f * i;
            rainbowRoad.GetChild(i).GetComponent<Renderer>().material.SetFloat("_Distance", d + delta);
        }
    }

}
