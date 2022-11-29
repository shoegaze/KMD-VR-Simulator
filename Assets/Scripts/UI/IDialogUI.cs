using UnityEngine;

namespace UI {
	public interface IDialogUI {
		public GameObject Instance { get; }
		
		void SetAlpha(float a);
	}
}
