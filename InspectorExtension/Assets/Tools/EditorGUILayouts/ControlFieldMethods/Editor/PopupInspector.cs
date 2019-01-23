using UnityEditor;

namespace InspectorExtension.EditorGUILayouts {	[CustomEditor (typeof (Popup))]
	public class PopupInspector : Editor {
		Popup _target;

		void OnEnable () {
			_target = (Popup)target;
		}

		public override void OnInspectorGUI () {
			// popup with default indices
			_target.PopupIndex = EditorGUILayout.Popup ("Popup", _target.PopupIndex, _target.Options);
			EditorGUILayout.LabelField ("Popup Index", _target.PopupIndex.ToString ());

			// popup with custom indices, defined by _target.OptionValues
			_target.IntPopupIndex = EditorGUILayout.IntPopup (
				"IntPopup",
				_target.IntPopupIndex,
				_target.Options,
				_target.OptionValues
			);
			EditorGUILayout.LabelField ("IntPopup Index", _target.IntPopupIndex.ToString ());		}	}}