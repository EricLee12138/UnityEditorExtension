using UnityEngine;
using UnityEditor;

namespace InspectorExtension.CustomProperties {
	[CustomEditor (typeof (QuatConvertWithInspector))]	public class QuatConvInspector : Editor {
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
			_showDeg = EditorGUILayout.Foldout (_showDeg, "Rotation in Degree", true);			EditorGUILayout.BeginVertical ("box");
			if (_showDeg) {				// TODO: draw property _rotationDeg here				EditorGUILayout.PropertyField (_rotationDeg, true);
				_target.RotationDeg = _rotationDeg.vector3Value;
			}			EditorGUILayout.LabelField (
				string.Format(
					"Value: ( X: {0}, Y: {1}, Z: {2} )",
					_target.RotationDeg.x,
					_target.RotationDeg.y,
					_target.RotationDeg.z
				)
			);
			EditorGUILayout.EndVertical ();			_showRad = EditorGUILayout.Foldout (_showRad, "Rotation Rad", true);			EditorGUILayout.BeginVertical ("box");			if (_showRad) {				// TODO: draw property _rotationRad here				EditorGUILayout.PropertyField (_rotationRad, true);
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
			EditorGUILayout.EndVertical ();		}	}}
