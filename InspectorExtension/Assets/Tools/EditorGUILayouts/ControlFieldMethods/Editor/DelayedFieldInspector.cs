﻿using UnityEngine;
using UnityEditor;

namespace InspectorExtension.EditorGUILayouts {
	[CustomEditor (typeof (DelayedField))]
	public class DelayedFieldInspector : Editor {
		DelayedField _target;
		string _display;

		void OnEnable () {
			_target = (DelayedField)target;
		}

		public override void OnInspectorGUI () {
			// GUI style			GUIStyle style = new GUIStyle ();
			style.fontSize = 30;
			style.normal.background = Texture2D.whiteTexture;
			style.normal.textColor = Color.red;
			style.margin = new RectOffset (0, 0, 3, 3);
			style.padding = new RectOffset (10, 10, 10, 10);
			style.alignment = TextAnchor.MiddleLeft;

			// double
			_target.DoubleValue = EditorGUILayout.DelayedDoubleField ("Double Value", _target.DoubleValue, style, GUILayout.Height(50));

			// float
			_target.FloatValue = EditorGUILayout.DelayedFloatField ("Float Value", _target.FloatValue, style, GUILayout.Height (50));

			// int
			_target.IntValue = EditorGUILayout.DelayedIntField ("Int Value", _target.IntValue, style, GUILayout.Height (50));

			// text
			_target.TextValue = EditorGUILayout.DelayedTextField ("Text Value", _target.TextValue, style, GUILayout.Height (50));

			// update the dispalying text
			_display = string.Join ("\n", new string [] {
				"Delayed Double Value: " + _target.DoubleValue.ToString (),
				"Delayed Float Value: " + _target.FloatValue.ToString (),
				"Delayed Int Value: " + _target.IntValue.ToString (),
				"Delayed Text Value: " + _target.TextValue
			});

			// force redraw every time when _target changes
			if (GUI.changed) {
				EditorUtility.SetDirty (_target);
			}
		}

		private void OnSceneGUI () {			Handles.BeginGUI ();

			GUILayout.BeginArea (new Rect (10f, 10f, 360f, 100f));
			GUILayout.Label (_display);
			GUILayout.EndArea ();

			Handles.EndGUI ();
		}
	}
}