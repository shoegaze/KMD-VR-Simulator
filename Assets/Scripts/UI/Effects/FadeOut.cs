using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace UI.Effects {
	public class FadeOut : MonoBehaviour {
		[SerializeField] private DialogBox dialogBox;
		[SerializeField, Min(0f)] private float duration;
		[SerializeField] private UnityEvent finishedEvent;

		private bool isAnimating;
		private float startTime;

		public void DoFadeOut() {
			if (isAnimating) {
				return;
			}
			
			startTime = Time.time;
			StartCoroutine(Animate());
		}

		private IEnumerator Animate() {
			isAnimating = true;

			while (Time.time < startTime + duration) {
				var t = (Time.time - startTime) / duration;
				var a = 1f - Mathf.Clamp01(t);
				
				dialogBox.SetAlpha(a);
				
				yield return null;
			}
			
			dialogBox.SetAlpha(0f);

			isAnimating = false;
			finishedEvent?.Invoke();
		}
	}
}
