using UnityEngine;
using UnityEditor;

namespace InspectorExtension.EditorGUILayouts {
	[CustomEditor (typeof (CurveField))]
	public class CurveFieldInspector : Editor {
		CurveField _target;

		void OnEnable () {
			_target = (CurveField)target;
		}

		public override void OnInspectorGUI () {
			// First reload, no label, no extra options
			_target.CurveFirst = EditorGUILayout.CurveField (_target.CurveFirst);

			// Second reload, with a label and an expanded width
			_target.CurveSecond = EditorGUILayout.CurveField ("Curve Second", _target.CurveSecond, GUILayout.ExpandWidth (true));

			// Third reload, with a label, a tooltip and a size of 400 pixels * 100 pixels
			var guiContent = new GUIContent ("Curve Third", "This is the third curve.");
			var guiLayoutOptions = new GUILayoutOption [] {
				GUILayout.Width(400),
				GUILayout.Height(100)
			};
			_target.CurveThird = EditorGUILayout.CurveField (guiContent, _target.CurveThird, guiLayoutOptions);

			// Forth reload, painted in red and restrained between (0, 0) to (15, 15)
			_target.CurveForth = EditorGUILayout.CurveField (
				"CurveForth",
				_target.CurveForth,
				Color.red,
				new Rect(0, 0, 15, 15),
				GUILayout.Height(200)
			);
		}
	}
}