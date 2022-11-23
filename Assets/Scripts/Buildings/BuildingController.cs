using System.Linq;
using UnityEngine;

namespace Buildings {
	[RequireComponent(typeof(BuildingMovement))]
	public class BuildingController : MonoBehaviour {
		[SerializeField] private new Collider collider;

		private readonly Collider[] results = new Collider[1] { null };

		public bool IntersectsOtherBuildings(Vector3 origin) {
			var bounds = GetBounds();
			var t = transform;

			int size = Physics.OverlapBoxNonAlloc(
					origin, 
					bounds.extents, 
					results,
					t.rotation, 
					~LayerMask.NameToLayer("Building")
			);

			return size > 0;
		}
		
		private Bounds GetBounds() {
			return collider.bounds;
		}
	}
}