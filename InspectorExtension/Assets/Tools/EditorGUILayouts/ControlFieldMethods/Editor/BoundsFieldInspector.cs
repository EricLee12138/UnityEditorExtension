﻿using UnityEngine;
using UnityEditor;

namespace InspectorExtension.EditorGUILayouts {
	[CustomEditor (typeof (BoundsField))]
	public class LevelInspector : Editor {
		BoundsField _target;

		void OnEnable () {
			_target = (BoundsField)target;
		}

		public override void OnInspectorGUI () {
			// First reload, no label, no extra options
			var guiLayoutOptions = new GUILayoutOption [] {
				GUILayout.Width(400),
				GUILayout.Height(100)
			};
			_target.BoundsThird = EditorGUILayout.BoundsField (guiContent, _target.BoundsThird, guiLayoutOptions);
		}
	}
}