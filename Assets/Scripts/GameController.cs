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
}
