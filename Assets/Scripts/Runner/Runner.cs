using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour {

    public enum PowerState { LIGHTMAN, SINGULARITYMAN, GLITCHMAN, MYSTICMAN };

    private PowerState currentPower = PowerState.LIGHTMAN;
    private int currentLane = 0;

    private SpriteRenderer sprite;
    [SerializeField] private Transform lanes;

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

    public void ChangeLane(int lane) {
        if (currentLane != lane) {
            if (lane == -1) {
                transform.position = lanes.GetChild(0).position;

            } else if (lane == 0) {
                transform.position = lanes.GetChild(1).position;

            } else if (lane == 1) {
                transform.position = lanes.GetChild(2).position;
            }

            currentLane = lane;
        }
    }

    // delete this later
    private void Update() {
        // Power backup for PC
        if (Input.GetKeyDown(KeyCode.I)) {
            ChangePowerState(PowerState.LIGHTMAN);

        } else if (Input.GetKeyDown(KeyCode.O)) {
            ChangePowerState(PowerState.SINGULARITYMAN);

        } else if (Input.GetKeyDown(KeyCode.J)) {
            ChangePowerState(PowerState.GLITCHMAN);

        } else if (Input.GetKeyDown(KeyCode.K)) {
            ChangePowerState(PowerState.MYSTICMAN);

            // Movement backup for PC
        } else if (Input.GetKeyDown(KeyCode.W)) {
            ChangeLane(-1);

        } else if (Input.GetKeyDown(KeyCode.S)) {
            ChangeLane(0);

        } else if (Input.GetKeyDown(KeyCode.X)) {
            ChangeLane(1);
        }
    }

    public PowerState GetPowerState() { return currentPower; }

}
