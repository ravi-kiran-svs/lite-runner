using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    [SerializeField] private GameObject[] Obs;
    [SerializeField] private GameObject NoneObs;

    private int nextObsSpawn = 20;

    private void Update() {
        if (Road.GetDistanceTravelled() >= (nextObsSpawn - 10)) {
            SpawnObsLine();
            nextObsSpawn += 10;
        }
    }

    private void SpawnObsLine() {
        int obsPos = Random.Range(0, 3);

        for (int i = 0; i < 3; i++) {
            if (i == obsPos) {
                Instantiate(Obs[Random.Range(0, 4)], transform.GetChild(i));

            } else {
                Instantiate(NoneObs, transform.GetChild(i));
            }
        }
    }

}
