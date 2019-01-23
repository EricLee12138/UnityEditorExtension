using UnityEngine;
using UnityEditor;

namespace InspectorExtension.BuiltInProperties {	public class BuiltInGUIStyles : EditorWindow {
		Vector2 _scroll = Vector2.zero;

		[MenuItem("Tools/Built In Styles/Display")]
		static void Display () {			GetWindow (typeof (BuiltInGUIStyles));		}

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
				// style name				EditorGUILayout.SelectableLabel (style.name, GUIStyle.none, GUILayout.Width(100));
				EditorGUILayout.Space ();				// style content				EditorGUILayout.SelectableLabel (style.name, style);
				EditorGUILayout.EndHorizontal ();			}

			EditorGUILayout.EndScrollView ();		}
	}}
