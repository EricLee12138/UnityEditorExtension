﻿using UnityEngine;
using UnityEditor;

namespace InspectorExtension.BuiltInProperties {
		Vector2 _scroll = Vector2.zero;

		[MenuItem("Tools/Built In Styles/Display")]
		static void Display () {

		void OnGUI () {
			_scroll = EditorGUILayout.BeginScrollView (_scroll);
			foreach (GUIStyle style in GUI.skin.customStyles) {
				GUIContent content = new GUIContent (style.name);
				float minWidth = 0, maxWidth = 0;
				float minHeight = 0, maxHeight = 0;

				style.CalcMinMaxWidth (content, out minWidth, out maxWidth);
				minHeight = style.CalcHeight (content, minWidth);
				maxHeight = style.CalcHeight (content, maxWidth);

				EditorGUILayout.BeginHorizontal ("box", GUILayout.Height(maxHeight));

				EditorGUILayout.Space ();


			EditorGUILayout.EndScrollView ();
