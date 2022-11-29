using UnityEngine;

namespace State.Behaviors {
	public class BehaviorEnterTheTrain : StateBehavior {
		[SerializeField] private GameObject introUI;
		[SerializeField] private GameObject teleporter;
		
		public override GameState State => GameState.EnterTheTrain;
		
		public override void OnBeforeTransition(GameState from) {
			introUI.SetActive(true);
		}

		public override void OnAfterTransition(GameState to) {
			introUI.SetActive(false);
			teleporter.SetActive(false);
		}
		
		public override void OnUpdate(GameController game, StateMachine stateMachine) { }

		public void EnableTeleporter() {
			teleporter.SetActive(true);
		}

		public void TransitionToSitDown() {
			Fsm.Transition(GameState.SitDown);
		}
	}
}
