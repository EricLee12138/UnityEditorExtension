﻿using UnityEngine;
using UnityEditor;

namespace InspectorExtension.CustomProperties {
	[CustomEditor (typeof (QuatConvertWithInspector))]
		QuatConvertWithInspector _target;

		bool _showDeg, _showRad;
		SerializedObject _object;
		SerializedProperty _rotationDeg, _rotationRad;

		private void OnEnable () {
			_target = (QuatConvertWithInspector)target;
			_object = new SerializedObject (_target);
			_rotationDeg = _object.FindProperty ("_rotationDeg");
			_rotationRad = _object.FindProperty ("_rotationRad");
		}

		public override void OnInspectorGUI () {
			_showDeg = EditorGUILayout.Foldout (_showDeg, "Rotation in Degree", true);
			if (_showDeg) {
				_target.RotationDeg = _rotationDeg.vector3Value;
			}
				string.Format(
					"Value: ( X: {0}, Y: {1}, Z: {2} )",
					_target.RotationDeg.x,
					_target.RotationDeg.y,
					_target.RotationDeg.z
				)
			);
			EditorGUILayout.EndVertical ();
				_target.RotationRad = _rotationRad.vector3Value;
			}
			EditorGUILayout.LabelField (
				string.Format (
					"Value: ( X: {0}, Y: {1}, Z: {2} )",
					_target.RotationRad.x,
					_target.RotationRad.y,
					_target.RotationRad.z
				)
			);
			EditorGUILayout.EndVertical ();