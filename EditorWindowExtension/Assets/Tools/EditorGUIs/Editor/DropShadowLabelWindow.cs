using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.EditorGUIs {	public class DropShadowLabelWindow : EditorWindow {		[MenuItem ("Tools/EditorGUI/DropShadowLabel Window")]		static void Open () {			EditorWindow window = GetWindow (typeof (DropShadowLabelWindow), false, "DropShadowLabel");			window.Show ();		}

		void OnGUI () {
			EditorGUI.LabelField (new Rect (5, 5, 200, 17), "This is a common label.");			EditorGUI.DropShadowLabel (new Rect (5, 27, 200, 17), "This is a label with drop shadow.");		}	}
}