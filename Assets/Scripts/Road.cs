using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour {

    [SerializeField] private float speed = 5;

    private float startTime = 0;
    private float distanceTravelled = 0;

    private void Awake() {
        startTime = Time.time;
    }

    private void Update() {
        float currentTime = Time.time;

        float timePassed = currentTime - startTime;
        distanceTravelled = speed * timePassed;
    }

    public float getDistanceTravelled() {
        return distanceTravelled;
    }

}
