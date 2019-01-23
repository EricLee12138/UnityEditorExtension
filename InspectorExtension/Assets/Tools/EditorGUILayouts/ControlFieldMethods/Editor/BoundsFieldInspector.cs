using UnityEngine;
using UnityEditor;

namespace InspectorExtension.EditorGUILayouts {
	[CustomEditor (typeof (BoundsField))]
	public class LevelInspector : Editor {
		BoundsField _target;

		void OnEnable () {
			_target = (BoundsField)target;
		}

		public override void OnInspectorGUI () {
			// First reload, no label, no extra options			_target.BoundsFirst = EditorGUILayout.BoundsField (_target.BoundsFirst);			// Second reload, with a label and a height of 200 pixels			_target.BoundsSecond = EditorGUILayout.BoundsField ("Bounds Second", _target.BoundsSecond, GUILayout.Height (200));			// Third reload, with a label, a tooltip and a size of 400 pixels * 100 pixels			var guiContent = new GUIContent("Bounds Third", "This is the third bounds.");
			var guiLayoutOptions = new GUILayoutOption [] {
				GUILayout.Width(400),
				GUILayout.Height(100)
			};
			_target.BoundsThird = EditorGUILayout.BoundsField (guiContent, _target.BoundsThird, guiLayoutOptions);
		}
	}
}
