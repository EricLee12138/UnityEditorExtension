using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.EditorGUIs {	public class FocusTextInControlWindow : EditorWindow {		string _text1 = "Hello";		string _text2 = "Hello";		[MenuItem ("Tools/EditorGUI/FocusTextInControl Window")]		static void Open () {			EditorWindow window = GetWindow (typeof (FocusTextInControlWindow), false, "FocusTextInControl");			window.Show ();		}		void OnGUI () {			GUI.SetNextControlName ("Control 1");			_text1 = EditorGUI.TextField (new Rect (5, 5, 400, 17), new GUIContent ("Control 1"), _text1);			GUI.SetNextControlName ("Control 2");			_text2 = EditorGUI.TextField (new Rect (5, 27, 400, 17), new GUIContent ("Control 2"), _text2);			if (GUI.Button (new Rect (5, 71, 400, 17), "Focus on Control 1")) {				EditorGUI.FocusTextInControl ("Control 1");			}			if (GUI.Button (new Rect (5, 93, 400, 17), "Focus on Control 2")) {				EditorGUI.FocusTextInControl ("Control 2");			}
			if (GUI.Button (new Rect (5, 137, 400, 17), "Remove Focus")) {
				EditorGUI.FocusTextInControl (null);
			}		}	}
}