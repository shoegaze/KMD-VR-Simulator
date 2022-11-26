﻿using UnityEngine;

namespace State.Behaviors {
	public interface IStateBehavior {
		GameState State { get; }

		// bool CanTransition(GameState to);
		void OnBeforeTransition(GameState from);
		void OnAfterTransition(GameState from);
		void OnUpdate(GameController game, StateMachine stateMachine);
	}
}
