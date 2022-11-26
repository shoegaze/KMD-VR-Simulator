using UnityEngine;

namespace State.Behaviors {
	public abstract class StateBehavior : MonoBehaviour, IStateBehavior {
		public abstract GameState State { get; }
		public abstract void OnBeforeTransition(GameState from);
		public abstract void OnAfterTransition(GameState from);
		public abstract void OnUpdate(GameController game);

		private GameController game;
		private StateMachine stateMachine;

		protected void Start() {
			var g = GameObject.FindWithTag("GameController");
			
			game = g.GetComponent<GameController>();
			stateMachine = g.GetComponent<StateMachine>();
		}

		protected void Update() {
			OnUpdate(game);
		}
	}
}
