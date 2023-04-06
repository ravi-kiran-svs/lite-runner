using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour {

    private static float distanceTravelled = 0;

    [SerializeField] private float speed = 5;

    private float prevTime;

    private void Awake() {
        distanceTravelled = 0;
        prevTime = Time.time;
    }

    private void Update() {
        float currentTime = Time.time;

        float timePassed = currentTime - prevTime;

        distanceTravelled += speed * timePassed;

        prevTime = currentTime;
    }

    public static float GetDistanceTravelled() {
        return distanceTravelled;
    }

}
