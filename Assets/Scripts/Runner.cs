using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour {

    public enum PowerState { LIGHTMAN, SINGULARITYMAN, GLITCHMAN, MYSTICMAN };

    private PowerState currentPower = PowerState.LIGHTMAN;

    private SpriteRenderer sprite;

    private void Awake() {
        sprite = GetComponent<SpriteRenderer>();
    }

    public void ChangePowerState(PowerState power) {
        if (currentPower != power) {

            switch (power) {
                case PowerState.LIGHTMAN:
                    sprite.color = Color.white;
                    break;

                case PowerState.SINGULARITYMAN:
                    sprite.color = Color.black;
                    break;

                case PowerState.GLITCHMAN:
                    sprite.color = Color.green;
                    break;

                case PowerState.MYSTICMAN:
                    sprite.color = Color.magenta;
                    break;
            }

            currentPower = power;
        }
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.I)) {
            ChangePowerState(PowerState.LIGHTMAN);

        } else if (Input.GetKeyDown(KeyCode.O)) {
            ChangePowerState(PowerState.SINGULARITYMAN);

        } else if (Input.GetKeyDown(KeyCode.J)) {
            ChangePowerState(PowerState.GLITCHMAN);

        } else if (Input.GetKeyDown(KeyCode.K)) {
            ChangePowerState(PowerState.MYSTICMAN);

        }
    }

}
