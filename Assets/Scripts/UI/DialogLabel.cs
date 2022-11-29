using TMPro;
using UnityEngine;

namespace UI {
	public class DialogLabel : MonoBehaviour, IDialogUI {
		private TextMeshProUGUI text;

		protected void Awake() {
			text = GetComponent<TextMeshProUGUI>();
		}

		public GameObject Instance => gameObject;
		
		public void SetAlpha(float a) {
			text.alpha = a;
		}
	}
}
