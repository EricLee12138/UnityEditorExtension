using UnityEngine;
using UnityEditor;

namespace InspectorExtension.EditorGUILayouts {
	[CustomEditor (typeof (MaskField))]
	public class MaskFieldInspector : Editor {
		int _mask; 

		public override void OnInspectorGUI () {
			_mask = EditorGUILayout.MaskField ("Mask", _mask, new string [] { "Mask1", "Mask2", "Mask3", "Mask4", "Mask5" });
			EditorGUILayout.LabelField ("Current Mask", _mask.ToString ());
		}
	}
}