using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.EditorGUIs {
	public class ChangeCheckWindow : EditorWindow {

		Bounds _bound;
		Color _color;
		int _int;

		[MenuItem ("Tools/EditorGUI/ChangeCheck Window")]		static void Open () {			EditorWindow window = GetWindow (typeof (ChangeCheckWindow), false, "ChangeCheck");			window.Show ();		}
	
		void OnGUI () {
			EditorGUI.BeginChangeCheck ();
			_bound = EditorGUI.BoundsField (new Rect (5, 5, 200, 34), _bound);
			if (EditorGUI.EndChangeCheck ()) {				ShowNotification (new GUIContent ("Something changed."));
			}

			_color = EditorGUI.ColorField (new Rect (5, 44, 200, 17), _color);

			EditorGUI.BeginChangeCheck ();
			_int = EditorGUI.IntSlider (new Rect(5, 66, 200, 17), _int, -5, 5);
			if (EditorGUI.EndChangeCheck ()) {
				ShowNotification (new GUIContent ("Something changed."));
			}		}	}
}