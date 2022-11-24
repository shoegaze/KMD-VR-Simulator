using UnityEngine;

namespace Buildings {
	public class BuildingSpawner : MonoBehaviour {
		[SerializeField] private GameObject[] buildings;

		private GameObject nextBuilding;
		private GameObject currentBuilding;
		private bool instantiating;

		protected void Awake() {
			nextBuilding = GetRandomBuilding();
			currentBuilding = nextBuilding;
		}
	
		protected void Update() {
			// 1. Check if most recent building is outside of the bounding box of `nextBuilding`
			//	1.1 Instantiate `nextBuilding`
			//	1.2 Swap `currentBuilding` with `nextBuilding`
			//	1.3 Choose new random building and swap with `nextBuilding`
		
			if (CanSpawnNext()) {
				SpawnNext();
			}
		}

		private bool CanSpawnNext() {
			var controller = currentBuilding.GetComponent<BuildingController>();
			Debug.Assert(controller != null);
			
			return !controller.IntersectsOtherBuildings(transform.position);
		}

		private GameObject GetRandomBuilding() {
			int i = (int)(buildings.Length * Random.value);
			return buildings[i];
		}
	
		private void SpawnNext() {
			var building = Instantiate(nextBuilding, transform);
			
			currentBuilding = building;
			nextBuilding = GetRandomBuilding();
			// TODO: Set nextBuilding as hidden
		}
	}
}
