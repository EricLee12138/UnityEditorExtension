using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.PrefabCenter {	public class PrefabDetail : EditorWindow {

		public static void OpenPrefabDetail (GameObject prefab) {
			EditorWindow window = GetWindow (typeof (PrefabDetail), false, prefab.name);
			window.ShowPopup ();
		}

		private void OnGUI () {
			GUI.Label (new Rect (5, 5, 100, 100), "Hello World");		}

		private void OnLostFocus () {
		}	}
}