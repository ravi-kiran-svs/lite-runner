using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : Movable {

    private void Update() {
        base.Update();

        Vector2 p = transform.position;
        p.x = ((p.x + 5) % 10 + 10) % 10 - 5;
        transform.position = p;
    }

}
