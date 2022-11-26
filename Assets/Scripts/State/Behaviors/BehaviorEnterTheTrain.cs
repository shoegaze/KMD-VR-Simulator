using UnityEngine;

namespace State.Behaviors {
	public class BehaviorEnterTheTrain : StateBehavior {
		public override GameState State => GameState.EnterTheTrain;
		
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
