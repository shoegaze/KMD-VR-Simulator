using UnityEngine;

namespace State.Behaviors {
	public abstract class StateBehavior : MonoBehaviour, IStateBehavior {
		public abstract GameState State { get; }
		public abstract void OnBeforeTransition(GameState from);
		public abstract void OnAfterTransition(GameState from);
		public abstract void OnUpdate(GameController game, StateMachine stateMachine);
	}
}
