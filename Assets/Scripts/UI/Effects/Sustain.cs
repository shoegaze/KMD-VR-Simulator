using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace UI.Effects {
	public class Sustain : MonoBehaviour {
		[SerializeField, Min(0f)] private float duration;
		[SerializeField] private UnityEvent finishedEvent;

		private bool isAnimating;
		private float startTime;

		public void DoSustain() {
			if (isAnimating) {
				return;
			}
			
			startTime = Time.time;
			StartCoroutine(Animate());
		}

		private IEnumerator Animate() {
			isAnimating = true;

			while (Time.time < startTime + duration) {
				yield return null;
			}

			isAnimating = false;
			finishedEvent?.Invoke();
		}
	}
}
