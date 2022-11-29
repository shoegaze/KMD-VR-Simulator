using System;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace UI {
	public class DialogBox : MonoBehaviour, IDialogUI {
		[SerializeField] private UnityEvent enabledEvent;

		private new CanvasRenderer renderer;

		protected void Awake() {
			renderer = GetComponent<CanvasRenderer>();
		}

		protected void OnEnable() {
			enabledEvent?.Invoke();
			
			// Start invisible
			SetAlpha(0f);
		}

		public GameObject Instance => gameObject;
		
		public void SetAlpha(float a) {
			// Set this alpha
			renderer.SetAlpha(a);
			
			// Set children alpha
			var children = GetComponentsInChildren<IDialogUI>()
					.Where(ui => ui.Instance != gameObject);
			
			foreach (var child in children) {
				child.SetAlpha(a);
			}
		}
	}
}
