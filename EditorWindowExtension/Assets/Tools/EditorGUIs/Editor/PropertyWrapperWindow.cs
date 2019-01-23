using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.EditorGUIs {	public class PropertyWrapperWindow : EditorWindow {
		[MenuItem ("Tools/EditorGUI/PropertyWrapper Window")]
		static void Open () {
			EditorWindow window = GetWindow (typeof (PropertyWrapperWindow), false, "PropertyWrapper");
			window.Show ();
		}

		void OnGUI () {		}	}
}