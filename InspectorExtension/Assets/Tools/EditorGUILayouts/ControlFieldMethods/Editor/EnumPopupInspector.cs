using UnityEngine;
using UnityEditor;

namespace InspectorExtension.EditorGUILayouts {
	[CustomEditor (typeof (EnumPopup))]
	public class EnumPopupInspector : Editor {
		EnumPopup _target;

		void OnEnable () {
			_target = (EnumPopup)target;
		}

		public override void OnInspectorGUI () {
			// GUI style
			GUIStyle style = new GUIStyle ();
			style.fontSize = 30;
			style.normal.background = Texture2D.whiteTexture;
			style.normal.textColor = Color.red;
			style.margin = new RectOffset (0, 0, 3, 3);
			style.padding = new RectOffset (10, 10, 10, 10);
			style.alignment = TextAnchor.MiddleLeft;

			_target.Option = (EnumPopup.EnumOptions)EditorGUILayout.EnumPopup ("Options", _target.Option, style, GUILayout.Height (50));
		}
	}
}
