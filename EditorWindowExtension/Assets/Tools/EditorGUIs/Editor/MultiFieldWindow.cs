using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.EditorGUIs {	public class MultiFieldWindow : EditorWindow {
		int [] _ints = { 1, 2, 3 };
		float [] _floats = { 1.5f, 2.5f, 3.5f };
		GUIContent [] _contents = {
			new GUIContent("1"),
			new GUIContent("2"),
			new GUIContent("3")
		};

		[MenuItem ("Tools/EditorGUI/MultiField Window")]
		static void Open () {
			EditorWindow window = GetWindow (typeof (MultiFieldWindow), false, "MultiField");
			window.Show ();
		}

		void OnGUI () {			EditorGUI.MultiIntField (new Rect (5, 5, 400, 17), _contents, _ints);
			EditorGUI.MultiFloatField (new Rect (5, 27, 400, 17), _contents, _floats);		}	}
}