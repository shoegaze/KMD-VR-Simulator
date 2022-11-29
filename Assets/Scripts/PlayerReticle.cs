using UnityEngine;

public class PlayerReticle : MonoBehaviour {
	[SerializeField] private Shapes.Disc reticle;

	public void FillReticle(float t) {
		reticle.AngRadiansEnd = t * 2f * Mathf.PI;
	}
}
