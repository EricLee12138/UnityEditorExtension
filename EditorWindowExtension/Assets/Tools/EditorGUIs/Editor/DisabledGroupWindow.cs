using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace EditorWindowExtension.EditorGUIs {	public class DisabledGroupWindow : EditorWindow {
		bool _disabled;
		Rect _rect;
		[MenuItem ("Tools/EditorGUI/DisabledGroup Window")]
		static void Open () {
			EditorWindow window = GetWindow (typeof (DisabledGroupWindow), false, "DisabledGroup");
			window.Show ();
		}
	
		void OnGUI () {
			_disabled = EditorGUI.ToggleLeft (new Rect(5, 5, 200, 17), "Disabled", _disabled);

			EditorGUI.BeginDisabledGroup (_disabled);			_rect = EditorGUI.RectField (new Rect (5, 27, 200, 34), _rect);
			EditorGUI.EndDisabledGroup ();		}	}
}