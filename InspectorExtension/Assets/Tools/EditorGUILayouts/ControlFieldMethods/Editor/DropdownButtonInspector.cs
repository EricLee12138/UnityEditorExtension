using UnityEngine;
using UnityEditor;

namespace InspectorExtension.EditorGUILayouts {	[CustomEditor (typeof (DropdownButton))]	public class DropdownButtonInspector : Editor {		public override void OnInspectorGUI () {			if (EditorGUILayout.DropdownButton (new GUIContent ("Dropdown Button"), FocusType.Keyboard)) {				Debug.Log ("Dropdown Button Clicked");			}			if (GUILayout.Button ("Common Button")) {				Debug.Log ("Common Button Clicked");			}		}	}
}