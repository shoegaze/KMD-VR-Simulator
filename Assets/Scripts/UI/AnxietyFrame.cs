using TMPro;
using UnityEngine;

namespace UI {
	public class AnxietyFrame : MonoBehaviour {
		[SerializeField] private TextMeshProUGUI valueLabel;

		private GameController game;

		protected void Awake() {
			game = GameObject.FindWithTag("GameController").GetComponent<GameController>();
		}

		protected void OnGUI() {
			var anxiety = game.Anxiety;
			valueLabel.text = $"{anxiety}";
		}
	}
}
