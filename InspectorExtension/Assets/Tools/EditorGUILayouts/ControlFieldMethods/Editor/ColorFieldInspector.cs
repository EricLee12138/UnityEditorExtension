using UnityEngine;
using UnityEditor;

namespace InspectorExtension.EditorGUILayouts {
	[CustomEditor (typeof (ColorField))]
	public class ColorFieldInspector : Editor {
		ColorField _target;

		void OnEnable () {
			_target = (ColorField)target;
		}

		public override void OnInspectorGUI () {
			// First reload, no label, no extra options
			_target.ColorFirst = EditorGUILayout.ColorField (_target.ColorFirst);

			// Second reload, with a label and a width of 200 pixels
			_target.ColorSecond = EditorGUILayout.ColorField ("Color Second", _target.ColorSecond, GUILayout.ExpandWidth (true));

			// Third reload, with a label, a tooltip and a size of 400 pixels * 100 pixels
			var guiContent = new GUIContent ("Color Third", "This is the third color picker.");
			var guiLayoutOptions = new GUILayoutOption [] {
				GUILayout.ExpandWidth(false),
				GUILayout.MinWidth(200)
			};
			_target.ColorThird = EditorGUILayout.ColorField (guiContent, _target.ColorThird, guiLayoutOptions);

			// Forth reload, with no eyedropper, no alpha, in HDR mode
			guiContent = new GUIContent ("Color Forth", "This is the forth color picker.");
			guiLayoutOptions = new GUILayoutOption [] {
				GUILayout.ExpandWidth(true),
				GUILayout.Height(200)
			};
			_target.ColorForth = EditorGUILayout.ColorField (guiContent, _target.ColorForth, false, false, true, guiLayoutOptions);
		}
	}
}
