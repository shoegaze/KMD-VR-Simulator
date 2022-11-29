using System;
using System.Collections.Generic;
using State.Behaviors;
using UnityEngine;

namespace State {
	[RequireComponent(typeof(BehaviorNone))]
	[RequireComponent(
			typeof(BehaviorEnterTheTrain), 
			typeof(BehaviorSitDown), 
			typeof(BehaviorManSitsDown))]
	[RequireComponent(
			typeof(BehaviorManMovesToo), 
			typeof(BehaviorManStandsClose), 
			typeof(BehaviorLookAtHands))]
	[RequireComponent(
			typeof(BehaviorIgnoreHands), 
			typeof(BehaviorTimeUp), 
			typeof(BehaviorGameOver))]
	[RequireComponent(typeof(BehaviorWin))]
	public class StateMachine : MonoBehaviour {
		[SerializeField] private GameState state = GameState.None;

		public GameState State => state;

		private readonly Dictionary<GameState, IStateBehavior> behaviors = new();
		private GameController game;

		protected void Awake() {
			behaviors[GameState.None]           = GetComponent<BehaviorNone>();
			behaviors[GameState.EnterTheTrain]  = GetComponent<BehaviorEnterTheTrain>();
			behaviors[GameState.SitDown]        = GetComponent<BehaviorSitDown>();
			behaviors[GameState.ManSitsDown]    = GetComponent<BehaviorManSitsDown>();
			behaviors[GameState.ManMovesToo]    = GetComponent<BehaviorManMovesToo>();
			behaviors[GameState.ManStandsClose] = GetComponent<BehaviorManStandsClose>();
			behaviors[GameState.LookAtHands]    = GetComponent<BehaviorLookAtHands>();
			behaviors[GameState.IgnoreHands]    = GetComponent<BehaviorIgnoreHands>();
			behaviors[GameState.TimeUp]         = GetComponent<BehaviorTimeUp>();
			behaviors[GameState.GameOver]       = GetComponent<BehaviorGameOver>();
			behaviors[GameState.Win]            = GetComponent<BehaviorWin>();
		}

		protected void Start() {
			game = GameObject.FindWithTag("GameController").GetComponent<GameController>();
		}

		protected void Update() {
			behaviors[State].OnUpdate(game, this);
		}

		public void Transition(GameState to) {
			if (!CanTransition(to)) {
				throw new ArgumentException();
			}

			var from = state;
			behaviors[to].OnBeforeTransition(from);
			state = to;
			behaviors[from].OnAfterTransition(to);
		}

		private bool CanTransition(GameState to) {
			return (state, to) switch {
				(GameState.None,           GameState.EnterTheTrain)  => true,
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
				(GameState.IgnoreHands,    GameState.TimeUp)         => true,
				(GameState.TimeUp,         GameState.Win)            => true,
				_ => false
			};
		}
	}
}