using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructable : MonoBehaviour {

    [SerializeField] private float pToDestruct = -15;

    private void Update() {
        if (transform.position.x <= pToDestruct) {
            Destroy(gameObject);
        }
    }

}
