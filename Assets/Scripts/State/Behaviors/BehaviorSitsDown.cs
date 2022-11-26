using UnityEngine;

namespace State.Behaviors {
	public class BehaviorSitDown : StateBehavior {
		public override GameState State => GameState.SitDown;
    		
		public override void OnBeforeTransition(GameState from) {
			Debug.Log($"before -> {from}");
		}
		
		public override void OnAfterTransition(GameState from) {
			Debug.Log($"after -> {from}");
		}
		
		public override void OnUpdate(GameController game) {
			Debug.Log($"update: {State}");
		}
	}
}
