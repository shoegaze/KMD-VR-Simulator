using UnityEngine;

namespace Buildings {
	[RequireComponent(typeof(Collider))]
	public class BuildingSelfDestruct : MonoBehaviour {
		private void OnTriggerExit(Collider other) {
			if (other.CompareTag("BuildingsVolume")) {
				Destroy(transform.parent.gameObject);
			}
		}
	}
}
