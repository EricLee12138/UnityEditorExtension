using UnityEditor;

namespace InspectorExtension.EditorGUILayouts {
	[CustomEditor(typeof(Foldout))]
	public class FoldoutInspector : Editor {
		Foldout _target;
		bool _show;

		void OnEnable () {			_target = (Foldout)target;
		}

		public override void OnInspectorGUI () {
			_show = EditorGUILayout.Foldout (_show, "Foldout Usage", true);
			if (_show) {
				_target.Position = EditorGUILayout.Vector3Field ("Postion", _target.Position);
			}
		}
	}
}
