using UnityEngine;

namespace State.Behaviors {
	public abstract class StateBehavior : MonoBehaviour, IStateBehavior {
		public StateMachine Fsm => GameObject.FindWithTag("GameController").GetComponent<StateMachine>();
		
		public abstract GameState State { get; }
		public abstract void OnBeforeTransition(GameState from);
		public abstract void OnAfterTransition(GameState to);
		public abstract void OnUpdate(GameController game, StateMachine stateMachine);
	}
}
