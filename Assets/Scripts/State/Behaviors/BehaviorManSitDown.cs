﻿using UnityEngine;

namespace State.Behaviors {
	public class BehaviorManSitsDown : StateBehavior {
		public override GameState State => GameState.ManSitsDown;
        		
		public override void OnBeforeTransition(GameState from) {
			Debug.Log($"before -> {from}");
		}
		
		public override void OnAfterTransition(GameState from) {
			Debug.Log($"after -> {from}");
		}
		
		public override void OnUpdate(GameController game, StateMachine stateMachine) {
			Debug.Log($"update: {State}");
		}
	}
}
