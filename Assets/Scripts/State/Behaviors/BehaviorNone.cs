namespace State.Behaviors {
	public class BehaviorNone : StateBehavior {
		public override GameState State => GameState.EnterTheTrain;
		
		public override void OnBeforeTransition(GameState from) { }
		public override void OnAfterTransition(GameState from) { }
		
		public override void OnUpdate(GameController game, StateMachine stateMachine) {
			stateMachine.Transition(GameState.EnterTheTrain);
		}
	}
}
