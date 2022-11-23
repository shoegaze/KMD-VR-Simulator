using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour {
    public enum GameState {
        EnterTheTrain,
        SitDown,
        ManSitsDown,
        ManMovesToo,
        ManStandsClose,
        LookAtHands,
        IgnoreHands,
        TimeUp,
        GameOver,
        Win
    }

    [SerializeField] private GameState state = GameState.EnterTheTrain;

    public GameState State => state;

    private bool CanTransition(GameState to) {
        return (state, to) switch {
            (GameState.EnterTheTrain,  GameState.SitDown)        => true,
            (GameState.SitDown,        GameState.ManSitsDown)    => true,
            (GameState.ManSitsDown,    GameState.GameOver)       => true,
            (GameState.ManSitsDown,    GameState.ManMovesToo)    => true,
            (GameState.ManMovesToo,    GameState.GameOver)       => true,
            (GameState.ManMovesToo,    GameState.ManStandsClose) => true,
            (GameState.ManMovesToo,    GameState.Win)            => true,
            (GameState.ManStandsClose, GameState.LookAtHands)    => true,
            (GameState.LookAtHands,    GameState.GameOver)       => true,
            (GameState.ManStandsClose, GameState.IgnoreHands)    => true,
            (GameState.IgnoreHands,    GameState.Win)            => true,
            _ => false
        };
    }

    public void Transition(GameState to) {
        if (!CanTransition(to)) {
            throw new ArgumentException();
        }

        // OnBeforeTransition(GameState from, GameState to);
        state = to;
        // OnAfterTransition(GameState from, GameState to);
    }
}
