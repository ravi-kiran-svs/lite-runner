using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : Movables {

    private void Awake() {
        base.Awake();
    }

    private void Update() {
        base.Update();
        transform.position = new Vector2(5 - (distanceTravelled % 10), 0);
    }
}
