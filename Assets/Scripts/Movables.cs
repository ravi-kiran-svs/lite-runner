using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movables : MonoBehaviour {

    protected Road road;
    protected float initDistance;
    protected float distanceTravelled;

    protected void Awake() {
        road = transform.GetComponentInParent<Road>();
        initDistance = road.getDistanceTravelled();
    }

    protected void Update() {
        float currentDistance = road.getDistanceTravelled();
        distanceTravelled = currentDistance - initDistance;
    }

}
