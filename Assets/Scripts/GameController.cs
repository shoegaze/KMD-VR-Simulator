using State;
using UnityEngine;

[RequireComponent(typeof(StateMachine))]
public class GameController : MonoBehaviour {
	[SerializeField, Min(0f)] private float trainSpeed;
	[SerializeField, Min(0)] private int anxiety;

	private StateMachine state;

	public float TrainSpeed => trainSpeed;
	public int Anxiety => anxiety;

	protected void Awake() {
		state = GetComponent<StateMachine>();
	}
	
	// TODO
}