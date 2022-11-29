using UnityEngine;

namespace State.Behaviors {
	public class BehaviorManMovesToo : StateBehavior {
		public override GameState State => GameState.ManMovesToo;
    		
		public override void OnBeforeTransition(GameState from) {
			Debug.Log($"before -> {from}");
		}
		
		public override void OnAfterTransition(GameState to) {
			Debug.Log($"after -> {to}");
		}
		
		public override void OnUpdate(GameController game, StateMachine stateMachine) {
			Debug.Log($"update: {State}");
		}
	}
}
