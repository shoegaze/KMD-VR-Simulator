using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Teleporter : MonoBehaviour {
	[SerializeField] private Transform destination;
	[SerializeField] private Transform lookAt;
	[SerializeField, Min(0f)] private float hoverDuration = 1f;
	[SerializeField] private PlayerReticle reticle;

	private TeleportationAnchor anchor;
	private GameObject source;
	private float hoverTime;
	private bool hovering;

	protected void Awake() {
		anchor = GetComponent<TeleportationAnchor>();
	}

	public void OnHoverEntered(HoverEnterEventArgs args) {
		source = args.interactorObject.transform.gameObject;
		hovering = true;
	}

	public void OnHoverExited(HoverExitEventArgs args) {
		hoverTime = 0f;
		hovering = false;
	}

	protected void Update() {
		if (hovering) {
			hoverTime += Time.deltaTime;
		}

		reticle.FillReticle(hoverTime / hoverDuration);

		if (hoverTime > hoverDuration) {
			Teleport();
		}
	}
	
	private void Teleport() {
		Debug.Log("teleporting");
		hovering = false;
		
		source.transform.position = destination.position;
		source.transform.LookAt(lookAt);
	}
}
