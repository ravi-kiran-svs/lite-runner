using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

    [SerializeField] private GameObject[] Obs;

    private int nextObsSpawn = 20;

    private void Update() {
        if (Road.GetDistanceTravelled() >= (nextObsSpawn - 10)) {
            SpawnObsLine();
            nextObsSpawn += 10;
        }
    }

    private void SpawnObsLine() {
        for (int i = 0; i < 3; i++) {
            int obsType = Random.Range(0, 4);
            Instantiate(Obs[obsType], transform.GetChild(i));
        }
    }

}
