﻿using UnityEditor;
using UnityEngine;

namespace InspectorExtension.DefaultAssets {
	[CustomEditor (typeof (SceneAsset))]

		SceneAsset _target;

		private void OnEnable () {
			_target = (SceneAsset)target;
		}

		public override void OnInspectorGUI () {
			EditorGUILayout.HelpBox ("This is a Unity scene named \"" + _target.name + "\".", MessageType.None);
		}
}