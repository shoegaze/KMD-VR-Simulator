using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(StateMachine))]
public class GameController : MonoBehaviour {
    [SerializeField, Min(0)] private int anxiety;

    private StateMachine state;

    protected void Awake() {
        state = GetComponent<StateMachine>();
    }

    protected void Update() {
        
    }
}
