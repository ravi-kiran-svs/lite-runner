using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MilestoneSpawner : MonoBehaviour {

    [SerializeField] private GameObject Milestone;
    [SerializeField] private GameObject Milestone100;

    private int nextMilestone = 20;

    private void Update() {
        if (Road.GetDistanceTravelled() >= (nextMilestone - 10)) {
            SpawnMilestone(nextMilestone);
            nextMilestone += 10;
        }
    }

    private void SpawnMilestone(int i) {
        GameObject milestone;

        if (i % 100 != 0) {
            milestone = Instantiate(Milestone, transform);
        } else {
            milestone = Instantiate(Milestone100, transform);
        }

        milestone.GetComponentInChildren<TMP_Text>().text = i.ToString();
    }

}
