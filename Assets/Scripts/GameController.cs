using System;
using UnityEngine;

[RequireComponent(typeof(StateMachine))]
public class GameController : MonoBehaviour {
	[SerializeField, Min(0f)] private float trainSpeed;
	[SerializeField, Min(0)] private int anxiety;

	private StateMachine state;

	public float TrainSpeed => trainSpeed;

	protected void Awake() {
		state = GetComponent<StateMachine>();
	}

	protected void Update() {
		// TODO: Create behaviors for each method?
		switch (state.State) {
			case GameState.EnterTheTrain:
				UpdateEnterTheTrain();
				return;
			
			case GameState.SitDown:
				UpdateSitDown();
				return;
			
			case GameState.ManSitsDown:
				UpdateManSitsDown();
				return;
			
			case GameState.ManMovesToo:
				UpdateManMovesToo();
				return;
			
			case GameState.ManStandsClose:
				UpdateManStandsClose();
				return;
			
			case GameState.LookAtHands:
				UpdateLookAtHands();
				return;
			
			case GameState.IgnoreHands:
				UpdateIgnoreHands();
				return;
			
			case GameState.TimeUp:
				UpdateTimeUp();
				return;
			
			case GameState.GameOver:
				UpdateGameOver();
				return;
			
			case GameState.Win:
				UpdateWin();
				return;
			
			default:
				return;
		}
	}

	private void UpdateEnterTheTrain() {
		throw new NotImplementedException();
	}

	private void UpdateSitDown() {
		throw new NotImplementedException();
	}

	private void UpdateManSitsDown() {
		throw new NotImplementedException();
	}

	private void UpdateManMovesToo() {
		throw new NotImplementedException();
	}

	private void UpdateManStandsClose() {
		throw new NotImplementedException();
	}

	private void UpdateLookAtHands() {
		throw new NotImplementedException();
	}

	private void UpdateIgnoreHands() {
		throw new NotImplementedException();
	}

	private void UpdateTimeUp() {
		throw new NotImplementedException();
	}

	private void UpdateGameOver() {
		throw new NotImplementedException();
	}

	private void UpdateWin() {
		throw new NotImplementedException();
	}
}