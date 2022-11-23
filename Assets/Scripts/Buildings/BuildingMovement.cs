using UnityEngine;

namespace Buildings {
	public class BuildingMovement : MonoBehaviour {
		[SerializeField] private Vector3 direction = Vector3.right;

		private GameController game;

		protected void Start() {
			game = GameObject.FindWithTag("GameController").GetComponent<GameController>();
		}

		protected void Update() {
			var t = transform;
			// distance = speed * time
			float distance = game.TrainSpeed * Time.deltaTime;
		
			t.Translate(distance * direction.normalized, Space.World);
		}
	}
}
